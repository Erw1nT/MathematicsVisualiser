Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Media

Namespace WindowsExt.Controls.ZoomBox

	Public Class ZoomBoxSettings
		Implements INotifyPropertyChanged

		Private _scaleFactor As Double = 1.0

		Public Sub New()
			Scale = New ScaleTransform()
			Translate = New TranslateTransform()

			Group = New TransformGroup()
			Group.Children.Add(Scale)
			Group.Children.Add(Translate)

		End Sub

		Friend Sub ResetZoomAndScroll()
			Translate.X = 0
			Translate.Y = 0
			Scale.ScaleX = 1
			Scale.ScaleY = 1
			ScaleFactor = 1
		End Sub

		Friend Sub SetZoom(relativeZoom As Double)
			Scale.ScaleX += relativeZoom
			Scale.ScaleY += relativeZoom
			ScaleFactor = Scale.ScaleX

			'Nicht herauszoomen
			If Scale.ScaleX < MinimumScaleFactor Or
						Scale.ScaleY < MinimumScaleFactor Then

				Scale.ScaleX = MinimumScaleFactor
				Scale.ScaleY = MinimumScaleFactor
				ScaleFactor = MinimumScaleFactor
			End If

		End Sub

		Friend Sub SetOffset(offset As Vector)
			Translate.X = offset.X
			Translate.Y = offset.Y
		End Sub

		Public ReadOnly Property Scale As ScaleTransform
		Public ReadOnly Property Translate As TranslateTransform
		Public ReadOnly Property Group As TransformGroup

		Public Property ScaleFactor As Double
			Get
				Return _scaleFactor
			End Get
			Set
				If Not Equals(_scaleFactor, Value) Then
					_scaleFactor = Value
					RaisePropertyChanged()
				End If
			End Set
		End Property

		Public Property MinimumScaleFactor As Double = 0.25

		Public Property ShowSettings As Boolean = False

		Public Property ScaleToPosition As Boolean = False


		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Sub RaisePropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

	End Class

End Namespace