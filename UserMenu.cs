using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjectPOS
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();

            Text = "직원 관리";//메인 부분
            
            dataGridView1.DataSource = DataManager.People;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)//어느 셀을 지정 선택했을때 그 정보가 텍스트 창으로 불러와지는 부분
        {
            try
            {
                Person person = dataGridView1.CurrentRow.DataBoundItem as Person;
                 textBox1_Name.Text= person.Name;
                 textBox2_BirthDay.Text = person.BirthDay;
                 textBox3_Phone.Text = person.PhoneNum;
                 textBox4_WorkingTime.Text = person.Time.ToString();
                 textBox5_Pay.Text = person.Payment.ToString();
                label7_TotalPay.Text = person.Totalpay.ToString();

            }
            catch(Exception exception)
            {

            }
        }
        
        private void Logout_Click(object sender, EventArgs e)//뒤로가기
        {
            this.Hide();//빈 화면으로 돌아가기
            Form1 LoginForm = new Form1();//로그인 폼으로 돌아감
            LoginForm.Show();//로그인 폼으로 돌아가게끔 해줌
        }

         private void AddEmployee_Click(object sender, EventArgs e) //직원추가
        {
            try
            {
                if (DataManager.People.Exists((x) => x.Name == textBox1_Name.Text) && DataManager.People.Exists((x)=>x.BirthDay==textBox2_BirthDay.Text))//이름과 생년월일이 이미 등록된 사람과 같다면 굳이 등록할 필요가 없다.
                 {
                    MessageBox.Show("이미 등록된 정보입니다.");//메세지박스를 띄워줌
                  }                
                else//그 외의 경우는
                {
                    Person person = new Person();//클래스를 생성
                    {
                        person.Name = textBox1_Name.Text;
                        person.BirthDay = textBox2_BirthDay.Text;
                        person.PhoneNum = textBox3_Phone.Text;
                        person.Time = int.Parse(textBox4_WorkingTime.Text);
                        person.Payment = int.Parse(textBox5_Pay.Text);
                        person.Totalpay = person.Time * person.Payment;//각각 텍스트박스에 적은 정보를 저장한다.
                    }
                    DataManager.People.Add(person);//사람 정보를 추가해서 저장한다.

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.People;
                    DataManager.Save();//그리드를 새로고침하고 xml로 저장
                }
             }
            catch (Exception exception)
            {

            }

        }

        private void Change_Click(object sender, EventArgs e)//기존 직원의 정보를 수정하는 부분
        {
            try
            {
                Person person = DataManager.People.Single((x) => x.Name == textBox1_Name.Text);
                person.Name = textBox1_Name.Text;
                person.BirthDay = textBox2_BirthDay.Text;
                person.PhoneNum = textBox3_Phone.Text;
                person.Time = int.Parse(textBox4_WorkingTime.Text);
                person.Payment = int.Parse(textBox5_Pay.Text);
                person.Totalpay = person.Time * person.Payment;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.People;
                DataManager.Save();
            }
            catch(Exception exception)
            {
                MessageBox.Show("선택된 사람이 없습니다.");
            }

        }

        private void Delete_Click(object sender, EventArgs e)//기존 직원 정보의 삭제
        {
            try
            {
                Person person = DataManager.People.Single((x) => x.Name == textBox1_Name.Text);//싱글은 동시성 동작
                DataManager.People.Remove(person);//데이터에 있던 사람을 지운다.

                dataGridView1.DataSource = null;//공백으로 만들어줌
                dataGridView1.DataSource = DataManager.People;//수정된 정보를 데이터그리드 항목에 넣어준다.
                DataManager.Save();//저장
            }
            catch(Exception exception)
            {
                MessageBox.Show("잘못된 접근입니다.");
            }
        }

        private void End_Click_1(object sender, EventArgs e)//프로그램 종료
        {
            Application.Exit();
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e) // 어떤 형태로든 UserMenu Form이 종료되면
        {
            DataManager.Save();
            Application.Exit(); // 모든 창 (Hide된 창 포함)을 종료한다.
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}