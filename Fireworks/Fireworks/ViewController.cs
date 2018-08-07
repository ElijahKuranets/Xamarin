using System;

using UIKit;

namespace Fireworks
{
    public partial class ViewController : UIViewController
    {
        partial void ButtonAbout_TouchUpInside(UIButton sender)
        {
            var aboutVC = (AboutViewController)this.Storyboard.InstantiateViewController("AboutViewController");

            this.PresentViewController(aboutVC, true, null);
        }

        SimpleParticleGen fireworks;

        protected ViewController(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            fireworks = new SimpleParticleGen(UIImage.FromFile("Xamarin_logo_1.png"), View);

            //buttonStart.TouchUpInside += delegate (object sender, EventArgs e)
           // {
            //    fireworks.Start();
           // };
        }


        partial void SliderSize_ValueChanged(UISlider sender)
        {
            fireworks.ScaleMax = (nfloat)sliderSize.Value;
        }

        partial void SwitchNight_ValueChanged(UISwitch sender)
        {
            if (switchNight.On)
                this.View.BackgroundColor = UIColor.FromRGB(25, 25, 112);
            else
                this.View.BackgroundColor = UIColor.White;
        }

       

       

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
