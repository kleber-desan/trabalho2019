﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xfw.ViewModel
{
    public abstract class BaseViewModel: BindableObject
    { 
        private bool isBusy;
    public bool IsBusy
        {
            get => isBusy;
            set {isBusy = value; OnPropertyChanged(); }
        }
        public bool IsNotBusy => !IsBusy;
        public async Task ExecuteBusyAction(Func<Task> theBuysAction)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                await theBuysAction();
            }
            catch (Exception ex)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(ex);
#endif
                throw;
            }
            finally
            {
                isBusy = false;

            }
        }
        public virtual Task Initialize()
        => Task.CompletedTask;

           }
    
}

