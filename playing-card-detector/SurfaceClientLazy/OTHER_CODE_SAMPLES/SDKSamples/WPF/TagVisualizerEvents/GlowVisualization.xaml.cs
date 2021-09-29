using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.Surface.Presentation.Controls;

namespace TagVisualizerEventsSample
{
    /// <summary>
    /// A simple "glow" visualization. It exposes a pair of methods, Enter() and Leave(),
    /// which you can call to indicate that it has entered or left other UI elements.
    /// </summary>
    /// <remarks>
    /// This implementation causes the visualization to fade out when it enters another
    /// object, and fade back in when it leaves. We use a count rather than a boolean
    /// toggle because it's possible to enter more than one item at a time (for example,
    /// entering a child doesn't equal leaving the parent).
    /// </remarks>
    public partial class GlowVisualization : TagVisualization
    {
        private int enterCount;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GlowVisualization()
        {
            InitializeComponent();

            Glow.RenderTransform = new ScaleTransform(1, 1);
        }

        /// <summary>
        /// Call to indicate that the visualization has entered another UI element.
        /// </summary>
        public void Enter()
        {
            ++enterCount;
            if (enterCount == 1)
            {
                Animate(0.5, 1.0, 0.4, 0.0, 1.0);
            }
        }

        /// <summary>
        /// Call to indicate that the visualization has left another UI element.
        /// </summary>
        public void Leave()
        {
            Debug.Assert(enterCount > 0);
            --enterCount;
            if (enterCount < 1)
            {
                Animate(0.2, 0.4, 1.0, 1.0, 0.0);
            }
        }

        /// <summary>
        /// Change the logical highlight "level" of the visualization (0 = totally
        /// un-highlighted, 1 = totally highlighted).
        /// </summary>
        /// <remarks>
        /// The implementation here is to affect transparency and size. "Highlighted"
        /// = opaque and large, "un-highlighted" = transparent and small.
        /// </remarks>
        /// <param name="seconds"></param>
        /// <param name="fromLevel"></param>
        /// <param name="toLevel"></param>
        /// <param name="accelerationRatio"></param>
        /// <param name="decelerationRatio"></param>
        private void Animate(
            double seconds,
            double fromLevel,
            double toLevel,
            double accelerationRatio,
            double decelerationRatio)
        {
            DoubleAnimation animation = new DoubleAnimation(
                fromLevel,
                toLevel,
                new Duration(TimeSpan.FromSeconds(seconds)));
            animation.AccelerationRatio = accelerationRatio;
            animation.DecelerationRatio = decelerationRatio;
            ScaleTransform transform = (ScaleTransform)Glow.RenderTransform;
            transform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
            transform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
            Glow.BeginAnimation(OpacityProperty, animation);
        }
    }
}