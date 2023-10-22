using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TP03;

namespace TP03
{
    public class PackageViewModel : INotifyPropertyChanged
    {
        private int trackingNumber;

        public int TrackingNumber
        {
            get => trackingNumber;
            set
            {
                if (trackingNumber != value)
                {
                    trackingNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        private string status;
        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime sendDate;
        public DateTime SendDate
        {
            get => sendDate;
            set
            {
                if (sendDate != value)
                {
                    sendDate = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime expectedDeliveryDate;
        public DateTime ExpectedDeliveryDate
        {
            get => expectedDeliveryDate;
            set
            {
                if (expectedDeliveryDate != value)
                {
                    expectedDeliveryDate = value;
                    OnPropertyChanged();
                }
            }
        }

        private string events;
        public string Events
        {
            get => events;
            set
            {
                if (events != value)
                {
                    events = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand TrackPackageCommand { get; }

        public PackageViewModel()
        {
            TrackPackageCommand = new Command(TrackPackage);
        }

        async void TrackPackage()
        {
            if (TrackingNumber > 0)
            {
                var packageService = new PackageService();
                var package = await packageService.GetPackageByTrackingNumberAsync(TrackingNumber);

                await App.Current.MainPage.Navigation.PushAsync(new PackageDetailsPage(package));
            }
            else
            {
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
