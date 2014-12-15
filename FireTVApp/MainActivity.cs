using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FireTVApp
{
    [Activity (Label = "FireTVApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Main);

            var imageAdapter = new ImageAdapter (this);
            var imageListView = FindViewById<GridView> (Resource.Id.Grid);
            imageListView.Adapter = imageAdapter;

            imageListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {

                var intent = new Intent(this, typeof(DetailActivity));
                intent.PutExtra("position", e.Position);
                StartActivity(intent);
            };
        }
    }

    class ImageAdapter : BaseAdapter
    {
        Context context;

        int[] images = { 
            Resource.Drawable.a, 
            Resource.Drawable.b,
            Resource.Drawable.c,
            Resource.Drawable.d,
            Resource.Drawable.e,
            Resource.Drawable.f,
            Resource.Drawable.g,
            Resource.Drawable.h,
            Resource.Drawable.i,
            Resource.Drawable.j,
            Resource.Drawable.k,
            Resource.Drawable.l,
            Resource.Drawable.m,
            Resource.Drawable.n,
            Resource.Drawable.o,
            Resource.Drawable.p,
            Resource.Drawable.q,
            Resource.Drawable.r,
            Resource.Drawable.s,
            Resource.Drawable.t,
            Resource.Drawable.v
        };

        public ImageAdapter (Context c)
        {
            context = c;
        }

        public override int Count { get { return images.Length; } }

        public override Java.Lang.Object GetItem (int position)
        {
            return null;
        }

        public override long GetItemId (int position)
        {
            return 0;
        }

        public override View GetView (int position, View convertView, ViewGroup parent)
        {

            var imageView = new ImageView (context);

            imageView.LayoutParameters = new GridView.LayoutParams (300, 300);
            imageView.SetScaleType (ImageView.ScaleType.CenterInside);
            imageView.SetPadding (10, 10, 10, 10);
            imageView.SetImageResource (images [position]);

            return imageView;
        }
    }
}