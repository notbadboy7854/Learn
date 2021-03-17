using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xa015_DataBinding
{
    public partial class MainPage : ContentPage
    {
        private string m_strPHONE; //내부용 변수


        //Xaml Binding 변수는 pulbic 으로 선언해도 안먹음
        //Xaml Binding 변수는 Property로 해야됨. prop 타이핑하 탭 2번
        public string PHONE
        { //외부에서 사용하는 변수
            get
            {
                return m_strPHONE;
            }
            set
            {
                m_strPHONE = value;
                OnPropertyChanged(); //Property에 갑 변경되었다고 알려
            }
        }

        


        public MainPage()
        {
            PHONE = "010-1234-5678";
            this.BindingContext = this; //Binding 변수 지정

            InitializeComponent();

            
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            PHONE = "010-4797-3619";
        }
    }
}
