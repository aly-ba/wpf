using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace TranslateTransformWinRT.Extensions
{
    public static class TranslateTransformExtensions
    {
        //static Storyboard storyBoard;
        public static void AnimateTo(this TranslateTransform translateTransform,
            Point point)
        {
            var storyboard = new Storyboard();

            AddAnimation(storyboard, translateTransform, "X", point.X);
            AddAnimation(storyboard, translateTransform, "Y", point.Y);

            storyboard.Begin();
        }
        private static void AddAnimation(Storyboard storyboard,
           TranslateTransform translateTransform,
           string property,
           double toValue)
        {
            var animation = new DoubleAnimation
            {
                To = toValue,
                Duration = new Duration(TimeSpan.FromMilliseconds(500)),
                EasingFunction = new QuadraticEase()
            };
            Storyboard.SetTarget(animation, translateTransform);
            Storyboard.SetTargetProperty(animation, property);
            storyboard.Children.Add(animation);
        }
    }
}
