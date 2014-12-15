using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FireTVApp
{
    [Activity (Label = "DetailActivity")]			
    public class DetailActivity : Activity
    {
        ImageView imageView;

        int[] images = { 
            Resource.Drawable.a1, 
            Resource.Drawable.b1,
            Resource.Drawable.c1,
            Resource.Drawable.d1,
            Resource.Drawable.e1,
            Resource.Drawable.f1,
            Resource.Drawable.g1,
            Resource.Drawable.h1,
            Resource.Drawable.i1,
            Resource.Drawable.j1,
            Resource.Drawable.k1,
            Resource.Drawable.l1,
            Resource.Drawable.m1,
            Resource.Drawable.n1,
            Resource.Drawable.o1,
            Resource.Drawable.p1,
            Resource.Drawable.q1,
            Resource.Drawable.r1,
            Resource.Drawable.s1,
            Resource.Drawable.t1,
            Resource.Drawable.v1
        };
            
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Detail);

            int i = Intent.Extras.GetInt ("position");

            imageView = FindViewById<ImageView> (Resource.Id.DetailImageView);
            imageView.SetImageResource (images [i]);

        }

        protected override void OnPause ()
        {
            base.OnPause ();

            imageView.SetImageResource (0);
        }
    }
}