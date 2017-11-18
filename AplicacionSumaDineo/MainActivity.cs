using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace AplicacionSumaDineo
{
    [Activity(Label = "Aplicación Suma Dinero", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int _Cantidad = 0;
        int _Cant1 = 0;
        int _Cant2 = 0;
        int _Cant3 = 0;
        int _Cant4 = 0;
        int _Cant5 = 0;
        int _Cant6 = 0;
        int _Cant7 = 0;
        int _Cant8 = 0;
        int _Cant9 = 0;
        int _Cant10 = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btnagrega1 = FindViewById<Button>(Resource.Id.btnagregar1);
            btnagrega1.Click+=agrega;
            Button btnagrega2 = FindViewById<Button>(Resource.Id.btnagregar2);
            btnagrega2.Click += agrega;
            Button btnagrega3 = FindViewById<Button>(Resource.Id.btnagregar3);
            btnagrega3.Click += agrega;
            Button btnagrega4 = FindViewById<Button>(Resource.Id.btnagregar4);
            btnagrega4.Click += agrega;
            Button btnagrega5 = FindViewById<Button>(Resource.Id.btnagregar5);
            btnagrega5.Click += agrega;
            Button btnagrega6 = FindViewById<Button>(Resource.Id.btnagregar6);
            btnagrega6.Click += agrega;
            Button btnagrega7 = FindViewById<Button>(Resource.Id.btnagregar7);
            btnagrega7.Click += agrega;
            Button btnagrega8 = FindViewById<Button>(Resource.Id.btnagregar8);
            btnagrega8.Click += agrega;
            Button btnagrega9 = FindViewById<Button>(Resource.Id.btnagregar9);
            btnagrega9.Click += agrega;
            Button btnagrega10 = FindViewById<Button>(Resource.Id.btnagregar10);
            btnagrega10.Click += agrega;

            Button btnrestar1 = FindViewById<Button>(Resource.Id.btnrestar1);
            btnrestar1.Click += elimina;
            Button btnrestar2 = FindViewById<Button>(Resource.Id.btnrestar2);
            btnrestar2.Click += elimina;
            Button btnrestar3 = FindViewById<Button>(Resource.Id.btnrestar3);
            btnrestar3.Click += elimina;
            Button btnrestar4 = FindViewById<Button>(Resource.Id.btnrestar4);
            btnrestar4.Click += elimina;
            Button btnrestar5 = FindViewById<Button>(Resource.Id.btnrestar5);
            btnrestar5.Click += elimina;
            Button btnrestar6 = FindViewById<Button>(Resource.Id.btnrestar6);
            btnrestar6.Click += elimina;
            Button btnrestar7 = FindViewById<Button>(Resource.Id.btnrestar7);
            btnrestar7.Click += elimina;
            Button btnrestar8 = FindViewById<Button>(Resource.Id.btnrestar8);
            btnrestar8.Click += elimina;
            Button btnrestar9 = FindViewById<Button>(Resource.Id.btnrestar9);
            btnrestar9.Click += elimina;
            Button btnrestar10 = FindViewById<Button>(Resource.Id.btnrestar10);
            btnrestar10.Click += elimina;
        }

        private void agrega(object sender, EventArgs e)
        {
            TextView _textoTotal = FindViewById<TextView>(Resource.Id.txt_cantidad);
            Button btn = (Button)sender;
            switch (btn.Id)
            {
                case Resource.Id.btnagregar1:
                    _Cantidad = _Cantidad + 20000;
                    _Cant1++;
                    TextView _Edita = FindViewById<TextView>(Resource.Id.txtcantidad1);
                    _Edita.Text = _Cant1.ToString();
                    break;
                case Resource.Id.btnagregar2:
                    _Cantidad = _Cantidad + 10000;
                    _Cant2++;
                    TextView _Edita2 = FindViewById<TextView>(Resource.Id.txtcantidad2);
                    _Edita2.Text = _Cant2.ToString();
                    break;
                case Resource.Id.btnagregar3:
                    _Cantidad = _Cantidad + 5000;
                    _Cant3++;
                    TextView _Edita3 = FindViewById<TextView>(Resource.Id.txtcantidad3);
                    _Edita3.Text = _Cant3.ToString();
                    break;
                case Resource.Id.btnagregar4:
                    _Cantidad = _Cantidad + 1000;
                    _Cant4++;
                    TextView _Edita4 = FindViewById<TextView>(Resource.Id.txtcantidad4);
                    _Edita4.Text = _Cant4.ToString();
                    break;
                case Resource.Id.btnagregar5:
                    _Cantidad = _Cantidad + 500;
                    _Cant5++;
                    TextView _Edita5 = FindViewById<TextView>(Resource.Id.txtcantidad5);
                    _Edita5.Text = _Cant5.ToString();
                    break;
                case Resource.Id.btnagregar6:
                    _Cantidad = _Cantidad + 100;
                    _Cant6++;
                    TextView _Edita6 = FindViewById<TextView>(Resource.Id.txtcantidad6);
                    _Edita6.Text = _Cant6.ToString();
                    break;
                case Resource.Id.btnagregar7:
                    _Cantidad = _Cantidad + 10;
                    _Cant7++;
                    TextView _Edita7 = FindViewById<TextView>(Resource.Id.txtcantidad7);
                    _Edita7.Text = _Cant7.ToString();
                    break;
                case Resource.Id.btnagregar8:
                    _Cantidad = _Cantidad + 5;
                    _Cant8++;
                    TextView _Edita8 = FindViewById<TextView>(Resource.Id.txtcantidad8);
                    _Edita8.Text = _Cant8.ToString();
                    break;
                case Resource.Id.btnagregar9:
                    _Cantidad = _Cantidad + 1;
                    _Cant9++;
                    TextView _Edita9 = FindViewById<TextView>(Resource.Id.txtcantidad9);
                    _Edita9.Text = _Cant9.ToString();
                    break;
                case Resource.Id.btnagregar10:
                    _Cantidad = _Cantidad + 50;
                    _Cant10++;
                    TextView _Edita10 = FindViewById<TextView>(Resource.Id.txtcantidad10);
                    _Edita10.Text = _Cant10.ToString();
                    break;
            }
            _textoTotal.Text = _Cantidad.ToString();
        }

        private void elimina(object sender, EventArgs e)
        {

            TextView _textoTotal = FindViewById<TextView>(Resource.Id.txt_cantidad);
            Button btn = (Button)sender;
            switch (btn.Id)
            {
                case Resource.Id.btnrestar1:
                    if(_Cant1>0)
                    {
                        _Cantidad = _Cantidad - 20000;
                        _Cant1--;
                        TextView _Edita = FindViewById<TextView>(Resource.Id.txtcantidad1);
                        _Edita.Text = _Cant1.ToString();
                    }
                    break;
                case Resource.Id.btnrestar2:
                    if (_Cant2 > 0)
                    {
                        _Cantidad = _Cantidad - 10000;
                        _Cant2--;
                        TextView _Edita2 = FindViewById<TextView>(Resource.Id.txtcantidad2);
                        _Edita2.Text = _Cant2.ToString();
                    }
                    break;
                case Resource.Id.btnrestar3:
                    if (_Cant3 > 0)
                    {
                        _Cantidad = _Cantidad - 5000;
                        _Cant3--;
                        TextView _Edita3 = FindViewById<TextView>(Resource.Id.txtcantidad3);
                        _Edita3.Text = _Cant3.ToString();
                    }
                    break;
                case Resource.Id.btnrestar4:
                    if (_Cant4 > 0)
                    {
                        _Cantidad = _Cantidad - 1000;
                        _Cant4--;
                        TextView _Edita4 = FindViewById<TextView>(Resource.Id.txtcantidad4);
                        _Edita4.Text = _Cant4.ToString();
                    }
                    break;
                case Resource.Id.btnrestar5:
                    if (_Cant5 > 0)
                    {
                        _Cantidad = _Cantidad - 500;
                        _Cant5--;
                        TextView _Edita5 = FindViewById<TextView>(Resource.Id.txtcantidad5);
                        _Edita5.Text = _Cant5.ToString();
                    }
                    break;
                case Resource.Id.btnrestar6:
                    if (_Cant6 > 0)
                    {
                        _Cantidad = _Cantidad - 100;
                        _Cant6--;
                        TextView _Edita6 = FindViewById<TextView>(Resource.Id.txtcantidad6);
                        _Edita6.Text = _Cant6.ToString();
                    }
                    break;
                case Resource.Id.btnrestar7:
                    if (_Cant7 > 0)
                    {
                        _Cantidad = _Cantidad - 10;
                        _Cant7--;
                        TextView _Edita7 = FindViewById<TextView>(Resource.Id.txtcantidad7);
                        _Edita7.Text = _Cant7.ToString();
                    }
                    break;
                case Resource.Id.btnrestar8:
                    if (_Cant8 > 0)
                    {
                        _Cantidad = _Cantidad - 5;
                        _Cant8--;
                        TextView _Edita8 = FindViewById<TextView>(Resource.Id.txtcantidad8);
                        _Edita8.Text = _Cant8.ToString();
                    }
                    break;
                case Resource.Id.btnrestar9:
                    if (_Cant9 > 0)
                    {
                        _Cantidad = _Cantidad - 1;
                        _Cant9--;
                        TextView _Edita9 = FindViewById<TextView>(Resource.Id.txtcantidad9);
                        _Edita9.Text = _Cant9.ToString();
                    }
                    break;
                case Resource.Id.btnrestar10:
                    if (_Cant10 > 0)
                    {
                        _Cantidad = _Cantidad - 50;
                        _Cant10--;
                        TextView _Edita10 = FindViewById<TextView>(Resource.Id.txtcantidad10);
                        _Edita10.Text = _Cant10.ToString();
                    }
                    break;
            }

            _textoTotal.Text = _Cantidad.ToString();
        }
    }
}

