using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPOS
{
    public partial class JoinManager : Form
    {
        public JoinManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//뒤로가기 버튼
        {
            this.Hide();
            Form1 form = new FinalProjectPOS.Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)//회원가입 정보 저장하기
        {
            try
            {
                if (DataManagerLogin.CEO.Exists((x) => x.Name == textBox1_name.Text) && DataManagerLogin.CEO.Exists((x) => x.BirthDay == textBox2_birth.Text))
                //이미 xml파일에 존제하는 데이터가 있는지 확인함. 이름과 생년월일이 같으면 동일인물이라고 체크 할 것임
                {
                    MessageBox.Show("이미 존재하는 정보가 있습니다.");//만약 있다면 있다는 안내메세지를 띄워줄것임 그리고 다시 쳐야함
                }
                else
                {
                    JoinIn Member = new JoinIn()//텍스트에 정보를 입력받는다.
                    {
                        Name = textBox1_name.Text,//이름
                        BirthDay = textBox2_birth.Text,//생일
                        PhoneNum = textBox3_phone.Text,//전화번호
                        ID = textBox4_id.Text,//아이디
                        Password = textBox5_pw.Text//비밀번호
                    };
                    DataManagerLogin.CEO.Add(Member);//추가해서
                    DataManagerLogin.Save();//저장
                    MessageBox.Show("회원가입이 완료되었습니다!");//저장 후에 회원가입 완료 메세지 지정
                    this.Hide();
                    Form1 Login = new Form1();
                    Login.Show();//로그인창을 띄움
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void CheckID_Click(object sender, EventArgs e)//ID 중복검사 부분
        {
            if (DataManagerLogin.CEO.Exists((x) => x.ID == textBox4_id.Text))
            {
                MessageBox.Show("중복되는 아이디 입니다. 다시 입력해주세요.");
            }
            else
                MessageBox.Show("사용가능한 아이디 입니다!");
        }
    }
}
