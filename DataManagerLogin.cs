using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;//xml사용을 위한것

namespace FinalProjectPOS
{
    class DataManagerLogin//로그인을 위한 정보 저장 즉 회원가입 정보 저장을 위한 xml 파일 형성
    {
        public static List<JoinIn> CEO = new List<JoinIn>();//사람 클래스를 리스트로 만들어 줌(리스트 이름 :CEO)

        static DataManagerLogin()//나는 데이터베이스를 모른다. 고로 Xml을 따라할 수밖에 없었다.(파일 입출력이 나에겐 너무 어렵습니다...)
        {
            Load();
        }
        public static void Load()
        {
            try//예외처리
            {
                string CEOOutput = File.ReadAllText(@"./CEO.xml");//xml파일 만들기 파일명 CEO(관리자니까!)
                XElement CEOXElment = XElement.Parse(CEOOutput);
                CEO = (from item in CEOXElment.Descendants("CEO")
                          select new JoinIn()
                          {
                              Name = item.Element("name").Value,
                              BirthDay = item.Element("birthday").Value,
                              PhoneNum = item.Element("phone").Value,
                              ID = item.Element("ID").Value,
                              Password = item.Element("password").Value
                          }).ToList<JoinIn>();
            }
            catch (FileNotFoundException exception)
            {
                Save();
            }
        }
        public static void Save()
        {
            String CEOOutput = "";
            CEOOutput += "<member>\n";
            foreach (var item in CEO)
            {
                CEOOutput += "<ceo>\n";
                CEOOutput += " <name>" + item.Name + "</name>\n";
                CEOOutput += " <birthday>" + item.BirthDay + "</birthday>\n";
                CEOOutput += " <phone>" + item.PhoneNum + "</phone>\n";
                CEOOutput += " <ID>" + item.ID + "</ID>\n";
                CEOOutput += " <password>" + item.Password + "</password>\n";
                CEOOutput += "</ceo>\n";
            }
            CEOOutput += "</member>\n";

            File.WriteAllText(@"./CEO.xml", CEOOutput);
        }
    }
}
