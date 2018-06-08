using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//파일 저장

namespace FinalProjectPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataManager.Load(); // 프로그램이 시작하면 파일로부터 데이터를 읽어온다.
        }

        private void LOGIN_Click(object sender, EventArgs e)//로그인 부분
        {
            if ((ID_txt.Text == "hjpark1397" && PW_txt.Text == "guswn305") || ((DataManagerLogin.CEO.Exists((x) => x.ID == ID_txt.Text) && DataManagerLogin.CEO.Exists((x) => x.Password == PW_txt.Text))))//초기 지정^^...회원가입은 차차 만들도록 할게요..
            {                
                this.Hide();
                UserMenu usermenu1 = new UserMenu();
                usermenu1.Show();//다음창 띄워주기
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 옳지 않습니다.");//아이디나 비번이 틀렸을 경우
            }
;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();//윈도우폼 종료 매서드
        }

        private void Join_Click(object sender, EventArgs e)//회원가입부분
        {
            this.Hide();
            JoinManager manager = new JoinManager();
            manager.Show();//회원가입 창을 띄워줌
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 프로세스 누적을 막는다.
        {
            Application.Exit();
        }
    }
}
