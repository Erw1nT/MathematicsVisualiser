using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MathematicsVisualiser.View.ZoomBox
{

	/// <summary>
	/// Interaktionslogik für ZoomBox.xaml
	/// </summary>
	public partial class ZoomBoxView : UserControl
	{

		private Point _start;
		private Vector _newPosition;
		private bool _allowTranslate;

		public ZoomBoxView()
		{
			InitializeComponent();
			InitializeMouseHandler();
		}

		private void InitializeMouseHandler()
		{

			UserControl.MouseWheel += OnContentMouseWheel;
			ZoomContent.MouseLeftButtonDown += OnContentMouseLeftButtonDown;
			ZoomContent.MouseLeftButtonUp += OnContentMouseLeftButtonUp;
			UserControl.MouseMove += OnContentMouseMove;
			UserControl.MouseLeftButtonDown += OnContentMouseLeftButtonDown;

		}

		private void OnContentMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			ZoomContent.ReleaseMouseCapture();
			_allowTranslate = false;
		}

		private void OnContentMouseMove(object sender, MouseEventArgs e)
		{
			OnContentMouseMoveTranslate(sender, e);
			OnContentMouseMovePosition(sender, e);
		}

		private void OnContentMouseMoveTranslate(object sender, MouseEventArgs e)
		{

			//Capture mouse here to allow clicking child elements
			if (_allowTranslate && e.LeftButton == MouseButtonState.Pressed && !ZoomContent.IsMouseCaptured)
			{
				ZoomContent.CaptureMouse();
			}


			if (!ZoomContent.IsMouseCaptured)
			{
				return;
			}

			var delta = _start - e.GetPosition(ZoomGrid);

			//Fix for double-click reset
			if (Math.Abs(delta.Length) < Double.Epsilon)
			{
				return;
			}

			var offset = _newPosition - delta;
			Settings.SetOffset(offset);

		}

		private void OnContentMouseMovePosition(object sender, MouseEventArgs e)
		{

			var absoluteMousePositionOnZoomBox = Mouse.GetPosition(this);
			var zoomBoxCenter = new Point(ActualWidth / 2, ActualHeight / 2);

			var zoomBoxOrigin = Settings.Translate.Transform(zoomBoxCenter);

			var posRelativeToCenter = absoluteMousePositionOnZoomBox - zoomBoxOrigin;
			posRelativeToCenter.Y = -posRelativeToCenter.Y;
			posRelativeToCenter /= Settings.ScaleFactor;

			MousePoint = (Point) posRelativeToCenter;

		}

		private static Point GetPosition(Point zoomBoxCenter, ZoomBoxSettings settings, Point mousePos)
		{
			var trans = settings.Translate;
			var zoomBoxOrigin = trans.Transform(zoomBoxCenter);

			var posRelativeToCenter = mousePos - zoomBoxOrigin;
			posRelativeToCenter.Y = -posRelativeToCenter.Y;
			posRelativeToCenter /= settings.ScaleFactor;

			return (Point) posRelativeToCenter;
		}

		private void OnContentMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

			if (e.ClickCount == 2)
			{
				ResetZoomAndScroll();
				return;
			}

			_start = e.GetPosition(ZoomGrid);

			_newPosition.X = Settings.Translate.X;
			_newPosition.Y = Settings.Translate.Y;

			//The previous mouse capture was done here, but this stopped inner MouseLeftButtonUp from working
			//ZoomContent.CaptureMouse()
			_allowTranslate = true;

		}

		private void OnContentMouseWheel(object sender, MouseWheelEventArgs e)
		{
			e.Handled = true;

			var mousePos = Mouse.GetPosition(this);
			var zoomBoxCenter = new Point(ActualWidth / 2, ActualHeight / 2);
			var p1 = GetPosition(zoomBoxCenter, Settings, mousePos);

			var zoom = 0.0;

			if (e.Delta > 0)
			{
				zoom = 0.2;
			}
			else
			{
				zoom = -0.2;
			}

			Settings.SetZoom(zoom);

			var p2 = GetPosition(zoomBoxCenter, Settings, mousePos);
			var delta = (p2 - p1);
			delta *= Settings.ScaleFactor;

			if (Settings.ScaleToPosition)
			{
				Settings.Translate.X += delta.X;
				Settings.Translate.Y -= delta.Y;
			}

		}

		private void ResetZoomAndScroll()
		{
			Settings.ResetZoomAndScroll();
		}



		public UIElement CanvasContent
		{
			get { return (UIElement) GetValue(CanvasContentProperty); }
			set { SetValue(CanvasContentProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CanvasContent.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty CanvasContentProperty =
				DependencyProperty.Register("CanvasContent", typeof(UIElement), typeof(ZoomBoxView), new PropertyMetadata(null));




		public bool ShowControls
		{
			get { return (bool) GetValue(ShowControlsProperty); }
			set { SetValue(ShowControlsProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ShowControls.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ShowControlsProperty =
				DependencyProperty.Register("ShowControls", typeof(bool), typeof(ZoomBoxView), new PropertyMetadata(true));




		public Point MousePoint
		{
			get { return (Point) GetValue(MousePointProperty); }
			set { SetValue(MousePointProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MousePoint.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MousePointProperty =
				DependencyProperty.Register("MousePoint", typeof(Point), typeof(ZoomBoxView), new PropertyMetadata(new Point()));



		public ZoomBoxSettings Settings
		{
			get { return (ZoomBoxSettings) GetValue(SettingsProperty); }
			set { SetValue(SettingsProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Settings.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SettingsProperty =
				DependencyProperty.Register("Settings", typeof(ZoomBoxSettings), typeof(ZoomBoxView), new PropertyMetadata(new ZoomBoxSettings(), OnSettingsChanged));

		public static void OnSettingsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			var view = sender as ZoomBoxView;

			if (view == null)
			{
				return;
			}

			view.ZoomContent.RenderTransform = view.Settings.Group;
			view.ShowControls = view.Settings.ShowSettings;
		}



		public double VisualWidth
		{
			get { return (double) GetValue(VisualWidthProperty); }
			set { SetValue(VisualWidthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for VisualWidth.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty VisualWidthProperty =
				DependencyProperty.Register("VisualWidth", typeof(double), typeof(ZoomBoxView), new PropertyMetadata(1.0));




		public string PositionText
		{
			get { return (string) GetValue(PositionTextProperty); }
			set { SetValue(PositionTextProperty, value); }
		}

		// Using a DependencyProperty as the backing store for PositionText.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty PositionTextProperty =
				DependencyProperty.Register("PositionText", typeof(string), typeof(ZoomBoxView), new PropertyMetadata(string.Empty));



	}
}