using System;
using System.Drawing;
using Uno.Disposables;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Data;
using Uno.UI.DataBinding;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI;

#if XAMARIN_IOS_UNIFIED
using Foundation;
using UIKit;
#elif XAMARIN_IOS
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif

namespace Uno.UI.Views.Controls
{
	public partial class BindableUISwitch : UISwitch, DependencyObject
	{
		public BindableUISwitch()
		{
			InitializeBinder();
			ValueChanged += OnValueChanged;
		}

		private void OnValueChanged(object sender, EventArgs e)
		{
			IsOn = On;
		}

		public BindableUISwitch(RectangleF frame)
			: base(frame)
		{
			InitializeBinder();
		}

		public BindableUISwitch(NSCoder coder)
			: base(coder)
		{
			InitializeBinder();
		}

		public BindableUISwitch(NSObjectFlag t)
			: base(t)
		{
			InitializeBinder();
		}

		public BindableUISwitch(IntPtr handle)
			: base(handle)
		{
			InitializeBinder();
		}

		#region ThumbTintColorBrush DependencyProperty

		/// <summary>
		/// The color used to tint the appearance of the thumb.
		/// </summary>
		public Brush ThumbTintColorBrush
		{
			get { return (Brush)this.GetValue(ThumbTintColorBrushProperty); }
			set { this.SetValue(ThumbTintColorBrushProperty, value); }
		}

		public static readonly DependencyProperty ThumbTintColorBrushProperty =
			DependencyProperty.Register("ThumbTintColorBrush", typeof(Brush), typeof(BindableUISwitch), new PropertyMetadata(null, (s, e) => ((BindableUISwitch)s).OnThumbTintColorBrushChanged((Brush)e.NewValue)));

		private void OnThumbTintColorBrushChanged(Brush newValue)
		{
			if (newValue is SolidColorBrush asColorBrush)
			{
				ThumbTintColor = asColorBrush.Color;
			}
		}

		#endregion

		#region Foreground Alias Property

		/// <summary>
		/// An alias to the ThumbTintColorBrush property, in order to avoid binary breaking change.
		/// </summary>
		public Brush Foreground
		{
			get { return ThumbTintColorBrush; }
			set
			{
				if (!Brush.Equals(value ?? null, ThumbTintColorBrush))
				{
					ThumbTintColorBrush = value;
				}
			}
		}

		#endregion

		#region OnTintColorBrush DependencyProperty

		/// <summary>
		/// The color used to tint the appearance of the switch when it is turned on.
		/// </summary>
		public Brush OnTintColorBrush
		{
			get { return (Brush)this.GetValue(OnTintColorBrushProperty); }
			set { this.SetValue(OnTintColorBrushProperty, value); }
		}

		public static readonly DependencyProperty OnTintColorBrushProperty =
			DependencyProperty.Register("OnTintColorBrush", typeof(Brush), typeof(BindableUISwitch), new PropertyMetadata(null, (s, e) => ((BindableUISwitch)s).OnOnTintColorBrushChanged((Brush)e.NewValue)));

		private void OnOnTintColorBrushChanged(Brush newValue)
		{
			if (newValue is SolidColorBrush asColorBrush)
			{
				OnTintColor = asColorBrush.Color;
			}
		}

		#endregion

		#region Background Alias Property

		/// <summary>
		/// An alias to the ThumbTintColorBrush property, in order to avoid binary breaking change.
		/// </summary>
		public Brush Background
		{
			get { return OnTintColorBrush; }
			set
			{
				if (!Brush.Equals(value ?? null, OnTintColorBrush))
				{
					OnTintColorBrush = value;
				}
			}
		}

		#endregion

		#region TintColorBrush DependencyProperty

		/// <summary>
		/// The color used to tint the outline of the switch when it is turned off.
		/// </summary>
		public Brush TintColorBrush
		{
			get { return (Brush)this.GetValue(TintColorBrushProperty); }
			set { this.SetValue(TintColorBrushProperty, value); }
		}

		public static readonly DependencyProperty TintColorBrushProperty =
			DependencyProperty.Register("TintColorBrush", typeof(Brush), typeof(BindableUISwitch), new PropertyMetadata(null, (s, e) => ((BindableUISwitch)s).OnTintColorBrushChanged((Brush)e.NewValue)));

		private void OnTintColorBrushChanged(Brush newValue)
		{
			if (newValue is SolidColorBrush asColorBrush)
			{
				TintColor = asColorBrush.Color;
			}
		}

		#endregion

		#region IsOn DependencyProperty

		public bool IsOn
		{
			get { return (bool)GetValue(IsOnProperty); }
			set { SetValue(IsOnProperty, value); }
		}

		public static readonly DependencyProperty IsOnProperty =
			DependencyProperty.Register("IsOn", typeof(bool), typeof(BindableUISwitch), new PropertyMetadata(default(bool), (s, e) => ((BindableUISwitch)s)?.OnIsOnChanged(e)));


		private void OnIsOnChanged(DependencyPropertyChangedEventArgs e)
		{
			this.SetState((bool)e.NewValue, true);
		}

		#endregion
	}
}

