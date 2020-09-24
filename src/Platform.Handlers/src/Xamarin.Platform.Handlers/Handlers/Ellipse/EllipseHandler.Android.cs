﻿using Xamarin.Forms;

namespace Xamarin.Platform.Handlers
{
    public partial class EllipseHandler : AbstractViewHandler<IShape, NativeEllipse>
    {
        protected override NativeEllipse CreateView()
        {
            return new NativeEllipse(Context);
        }

        public override SizeRequest GetDesiredSize(double widthConstraint, double heightConstraint)
        {
            if (TypedNativeView != null)
            {
                return TypedNativeView.GetDesiredSize();
            }

            return base.GetDesiredSize(widthConstraint, heightConstraint);
        }
    }
}
