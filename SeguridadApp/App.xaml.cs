﻿using SeguridadApp.Vistas;
using SeguridadApp.Vistas.TutorialIntro;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeguridadApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CrearCuenta();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
