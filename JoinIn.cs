using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPOS
{
    class JoinIn//회원가입에 사용될 클래스
    {
        public string Name { get; set; }//이름

        public string BirthDay { get; set; }//생일

        public string PhoneNum { get; set; }//전화번호

        public string ID { get; set; }//아이디

        public string Password { get; set; }//비밀번호
    }
}
