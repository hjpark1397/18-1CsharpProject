using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectPOS
{
   public class Person//사람의 정보 저장할 수 있는 클래스
    {
        public string Name { get; set; }//이름

        public string BirthDay { get; set; }//생일

        public string PhoneNum { get; set; }//전화번호

        public int Payment { get; set; }//돈

        public int Time { get; set; }//시간

        public int Totalpay { get; set; }//총 임금
    }
}
