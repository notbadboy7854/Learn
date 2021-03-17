using System;
using System.ComponentModel;

namespace xa016Test
{
    public class Test : INotifyPropertyChanged
    {
        //INotifyPropertyChanged 의 인터페이스 
        public event PropertyChangedEventHandler PropertyChanged;

        int m_Count = 7;

        public int count
        {
            get
            {
                return m_Count;
            }
            set
            {
                m_Count = value;

                if (null != PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("count"));
                }


            }
        }
    }
}
