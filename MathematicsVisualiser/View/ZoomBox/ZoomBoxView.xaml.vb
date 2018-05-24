Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Windows.Media
Imports Components.WindowsExt.Controls.AttachedProperties

Namespace WindowsExt.Controls.ZoomBox

	Public Class ZoomBoxView

#Region "Attributes"

		Private _start As Point
		Private _newPosition As New Vector
		Private _allowTranslate As Boolean

#End Region

#Region "Initialize"

		Public Sub New()
			InitializeComponent()
			'InitializeTransformGroups()
			InitializeMouseHandler()


		End Sub

		'Private Sub InitializeTransformGroups()
		'  Dim group As TransformGroup = Settings.Group
		'  ZoomContent.RenderTransform = group

		'  ShowControls = Settings.ShowSettings
		'End Sub

		Private Sub InitializeMouseHandler()
			AddHandler UserControl.MouseWheel, AddressOf OnContentMouseWheel
			AddHandler ZoomContent.MouseLeftButtonDown, AddressOf OnContentMouseLeftButtonDown
			AddHandler ZoomContent.MouseLeftButtonUp, AddressOf OnContentMouseLeftButtonUp
			AddHandler UserControl.MouseMove, AddressOf OnContentMouseMove
			AddHandler UserControl.MouseLeftButtonDown, AddressOf OnContentMouseLeftButtonDown
		End Sub

#End Region

#Region "Functions - Mouse"

		Private Sub OnContentMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs)
			ZoomContent.ReleaseMouseCapture()
			_allowTranslate = False
		End Sub

		Private Sub OnContentMouseMove(sender As Object, e As MouseEventArgs)
			OnContentMouseMoveTranslate(sender, e)
			OnContentMouseMovePosition(sender, e)
		End Sub

		Private Sub OnContentMouseMoveTranslate(sender As Object, e As MouseEventArgs)

			'Capture mouse here to allow clicking child elements
			If _allowTranslate AndAlso e.LeftButton = MouseButtonState.Pressed AndAlso Not ZoomContent.IsMouseCaptured Then
				ZoomContent.CaptureMouse()
			End If

			If Not ZoomContent.IsMouseCaptured Then
				Exit Sub
			End If

			Dim delta As Vector = _start - e.GetPosition(ZoomGrid)

			'Fix for double-click reset
			If Math.Abs(delta.Length) < Double.Epsilon Then
				Exit Sub
			End If

			Dim offset = _newPosition - delta
			Settings.SetOffset(offset)

		End Sub

		Private Sub OnContentMouseMovePosition(sender As Object, e As MouseEventArgs)

			Dim absoluteMousePositionOnZoomBox = Mouse.GetPosition(Me)
			Dim zoomBoxCenter = New Point(ActualWidth / 2, ActualHeight / 2)

			'Dim trans As New TranslateTransform(Settings.Translate.X, Settings.Translate.Y)
			'Dim trans As TranslateTransform =Settings.Translate
			Dim zoomBoxOrigin = Settings.Translate.Transform(zoomBoxCenter)

			Dim posRelativeToCenter = absoluteMousePositionOnZoomBox - zoomBoxOrigin
			posRelativeToCenter.Y = -posRelativeToCenter.Y
			posRelativeToCenter /= Settings.ScaleFactor

			MousePoint = posRelativeToCenter
			'e.Handled = True

		End Sub

		Private Shared Function GetPosition(zoomBoxCenter As Point, settings As ZoomBoxSettings, mousePos As Point) As Point

			Dim trans As TranslateTransform = settings.Translate
			Dim zoomBoxOrigin = trans.Transform(zoomBoxCenter)

			Dim posRelativeToCenter = mousePos - zoomBoxOrigin
			posRelativeToCenter.Y = -posRelativeToCenter.Y
			posRelativeToCenter /= settings.ScaleFactor
			Return posRelativeToCenter
		End Function


		Private Sub OnContentMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

			If e.ClickCount = 2 Then
				ResetZoomAndScroll()
				Exit Sub
			End If

			_start = e.GetPosition(ZoomGrid)

			_newPosition.X = Settings.Translate.X
			_newPosition.Y = Settings.Translate.Y

			'The previous mouse capture was done here, but this stopped inner MouseLeftButtonUp from working
			'ZoomContent.CaptureMouse()
			_allowTranslate = True

		End Sub

		Private Sub OnContentMouseWheel(sender As Object, e As MouseWheelEventArgs)

			e.Handled = True

			Dim mousePos = Mouse.GetPosition(Me)
			Dim zoomBoxCenter = New Point(ActualWidth / 2, ActualHeight / 2)
			Dim p1 = GetPosition(zoomBoxCenter, Settings, mousePos)

			Dim zoom As Double = If(e.Delta > 0, 0.2, -0.2)
			Settings.SetZoom(zoom)

			Dim p2 = GetPosition(zoomBoxCenter, Settings, mousePos)
			Dim delta = (p2 - p1)
			delta *= Settings.ScaleFactor

			If Settings.ScaleToPosition Then
				Settings.Translate.X += delta.X
				Settings.Translate.Y -= delta.Y
			End If

		End Sub

		Private Sub FillFilter() Handles UserControl.Loaded

			Dim uiElements As UIElementCollection = TryCast(Me.CanvasContent, Canvas)?.Children

			If uiElements Is Nothing Then
				Exit Sub
			End If

			For Each item As UIElement In uiElements

				Dim name = item.GetValue(DisplayNameAttachedProperty.DisplayNameProperty)

				Dim contentCheckBox = New Windows.Controls.CheckBox With {.Content = name}

				Dim myBinding = New Binding With {
					.Source = item,
					.Path = New PropertyPath("Visibility"),
					.Converter = New WindowsExt.Controls.Converter.VisibilityToBooleanConverter,
					.Mode = BindingMode.TwoWay,
					.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
				}

				BindingOperations.SetBinding(contentCheckBox, Windows.Controls.CheckBox.IsCheckedProperty, myBinding)
				FilterPanel.Children.Add(contentCheckBox)

			Next

		End Sub

#End Region

#Region "Functions"

		Private Sub ResetZoomAndScroll()
			Settings.ResetZoomAndScroll()
		End Sub

#End Region

#Region "CanvasContent Property"

		Public Property CanvasContent As UIElement
			Get
				Return CType(GetValue(CanvasContentProperty), UIElement)
			End Get
			Set
				SetValue(CanvasContentProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly CanvasContentProperty As DependencyProperty = DependencyProperty.Register("CanvasContent",
																																																																																																			GetType(UIElement),
																																																																																																			GetType(ZoomBoxView),
																																																																																																			New PropertyMetadata(Nothing))

#End Region


#Region "MousePoint Property"

		Public Property ShowControls As Boolean
			Get
				Return GetValue(ShowControlsProperty)
			End Get
			Set
				SetValue(ShowControlsProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly ShowControlsProperty As DependencyProperty = DependencyProperty.Register("ShowControls",
																																																																																																GetType(Boolean),
																																																																																																GetType(ZoomBoxView),
																																																																																																New PropertyMetadata(False))

#End Region


#Region "MousePoint Property"

		Public Property MousePoint As Point
			Get
				Return GetValue(MousePointProperty)
			End Get
			Set
				SetValue(MousePointProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly MousePointProperty As DependencyProperty = DependencyProperty.Register("MousePoint",
																																																																																																GetType(Point),
																																																																																																GetType(ZoomBoxView),
																																																																																																New PropertyMetadata(New Point))

#End Region

#Region "Settings Property"

		Public Property Settings As ZoomBoxSettings
			Get
				Return GetValue(SettingsProperty)
			End Get
			Set
				SetValue(SettingsProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly SettingsProperty As DependencyProperty = DependencyProperty.Register("Settings",
																																																																																														GetType(ZoomBoxSettings),
																																																																																														GetType(ZoomBoxView),
																																																																																														New PropertyMetadata(New ZoomBoxSettings, AddressOf OnSettingsChanged))
		Public Shared Sub OnSettingsChanged(sender As DependencyObject, e As DependencyPropertyChangedEventArgs)

			Dim view = TryCast(sender, ZoomBoxView)
			If view Is Nothing Then
				Exit Sub
			End If

			'Dim group As TransformGroup = view.Settings.Group
			view.ZoomContent.RenderTransform = view.Settings.Group
			view.ShowControls = view.Settings.ShowSettings

		End Sub

#End Region

#Region "VisualWidth Property"

		Public Property VisualWidth As Double
			Get
				Return GetValue(VisualWidthProperty)
			End Get
			Set
				SetValue(VisualWidthProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly VisualWidthProperty As DependencyProperty = DependencyProperty.Register("VisualWidth",
																																																																																																	GetType(Double),
																																																																																																	GetType(ZoomBoxView),
																																																																																																	New PropertyMetadata(1.0))

#End Region

#Region "PositionText Property"

		Public Property PositionText As String
			Get
				Return CType(GetValue(PositionTextProperty), String)
			End Get
			Set
				SetValue(PositionTextProperty, Value)
			End Set
		End Property

		Public Shared ReadOnly PositionTextProperty As DependencyProperty = DependencyProperty.Register("PositionText",
																																																																																																		GetType(String),
																																																																																																		GetType(ZoomBoxView),
																																																																																																		New PropertyMetadata(String.Empty))

#End Region

	End Class

End Namespace