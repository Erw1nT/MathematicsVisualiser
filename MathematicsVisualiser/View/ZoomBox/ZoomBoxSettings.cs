using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace MathematicsVisualiser.View.ZoomBox
{
	public class ZoomBoxSettings : INotifyPropertyChanged
	{

		private const double MinimumScaleFactor = 0.1;
		private double _scaleFactor = 1.0;

		public ZoomBoxSettings()
		{
			ShowSettings = true;
			ScaleToPosition = false;

			Scale = new ScaleTransform();
			Translate = new TranslateTransform();

			Group = new TransformGroup();
			Group.Children.Add(Scale);
			Group.Children.Add(Translate);
		}

		internal void ResetZoomAndScroll()
		{
			Translate.X = 0;
			Translate.Y = 0;
			Scale.ScaleX = 1;
			Scale.ScaleY = 1;
			ScaleFactor = 1;
		}

		internal void SetZoom(double relativeZoom)
		{
			Scale.ScaleX += relativeZoom;
			Scale.ScaleY += relativeZoom;
			ScaleFactor = Scale.ScaleX;

			//Nicht herauszoomen

			if (Scale.ScaleX < MinimumScaleFactor | Scale.ScaleY < MinimumScaleFactor)
			{
				Scale.ScaleX = MinimumScaleFactor;
				Scale.ScaleY = MinimumScaleFactor;
				ScaleFactor = MinimumScaleFactor;
			}
		}

		internal void SetOffset(Vector offset)
		{
			Translate.X = offset.X;
			Translate.Y = offset.Y;
		}

		public ScaleTransform Scale
		{
			get;
			set;
		}

		public TranslateTransform Translate
		{
			get;
			set;
		}

		public TransformGroup Group
		{
			get;
			set;
		}

		public bool ShowSettings
		{
			get;
			set;
		}

		public bool ScaleToPosition
		{
			get;
			set;
		}

		public Double ScaleFactor
		{
			get
			{
				return _scaleFactor;
			}
			set
			{
				if (!Equals(_scaleFactor, value))
				{
					_scaleFactor = value;
					OnPropertyChanged();
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}