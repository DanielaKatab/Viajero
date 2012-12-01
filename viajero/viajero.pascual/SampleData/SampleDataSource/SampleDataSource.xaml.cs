//      *********    NO MODIFIQUE ESTE ARCHIVO     *********
//      Este archivo se regenera mediante una herramienta de diseño.
//       Si realiza cambios en este archivo, puede causar errores.
namespace Expression.Blend.SampleData.SampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource { }
#else

	public class SampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/viajero.pascual;component/SampleData/SampleDataSource/SampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Modificar_viaje = string.Empty;

		public string Modificar_viaje
		{
			get
			{
				return this._Modificar_viaje;
			}

			set
			{
				if (this._Modificar_viaje != value)
				{
					this._Modificar_viaje = value;
					this.OnPropertyChanged("Modificar_viaje");
				}
			}
		}

		private string _Consultar_viaje = string.Empty;

		public string Consultar_viaje
		{
			get
			{
				return this._Consultar_viaje;
			}

			set
			{
				if (this._Consultar_viaje != value)
				{
					this._Consultar_viaje = value;
					this.OnPropertyChanged("Consultar_viaje");
				}
			}
		}

		private System.Windows.Media.ImageSource _imagen = null;

		public System.Windows.Media.ImageSource imagen
		{
			get
			{
				return this._imagen;
			}

			set
			{
				if (this._imagen != value)
				{
					this._imagen = value;
					this.OnPropertyChanged("imagen");
				}
			}
		}

		private string _Registrar_viaje = string.Empty;

		public string Registrar_viaje
		{
			get
			{
				return this._Registrar_viaje;
			}

			set
			{
				if (this._Registrar_viaje != value)
				{
					this._Registrar_viaje = value;
					this.OnPropertyChanged("Registrar_viaje");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}
#endif
}
