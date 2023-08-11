using Firebase.Auth;
using Firebase.Auth.Providers;
using SeguridadApp.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
//agregado
using Firebase.Auth.Repository;

namespace SeguridadApp.VistasModelo
{
    public class VMcrearcuenta
    {
        public async void CrearCuenta(string correo,string contraseña)
        {
            var authProvider = new FirebaseAuthConfig
            {
                ApiKey = Constantes.WebapyFirebase,
                AuthDomain = "xamarinseguridad.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                new GoogleProvider().AddScopes(correo),
                new EmailProvider()
                },
                UserRepository = new FileUserRepository("xamarinseguridad") 
            
            };
            var auth = new FirebaseAuthClient(authProvider);
            await auth.CreateUserWithEmailAndPasswordAsync(correo, contraseña);

        }
        public async void ValidarCuenta(string correo, string contraseña)
        {
            var authProvider = new FirebaseAuthConfig
            {
                ApiKey = Constantes.WebapyFirebase,
                AuthDomain = "xamarinseguridad.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                new GoogleProvider().AddScopes(correo),
                new EmailProvider()
                },
                UserRepository = new FileUserRepository("xamarinseguridad")

            };
            var auth = new FirebaseAuthClient(authProvider);
            var userCredential = await auth.SignInWithEmailAndPasswordAsync(correo, contraseña);
            var user = userCredential.User;
            var contenido = await user.GetIdTokenAsync();
            
        }

    }
}
