using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace testDrive.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {


        /*Aqui como usamos a interfafe INottifiedPropertyChanged
         * É necessário implemnetar a interface e usar a OnPropertyChanged
         * Sem isso é impossível notificar alterações da view para o CS
         */
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
