namespace BMS
{
	public class WeighObj : ObservableObject
	{
		private float weigh;
		public float Weigh
		{
			get { return weigh; }
			set
			{
				weigh = value;
				OnPropertyChanged("Weigh");
			}
		}

		public WeighObj()
		{
			weigh = 0;
		}
	}
}
