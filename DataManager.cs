using System;
using System.Collections.Generic;
using System.IO;//파일 입력
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;//xml다루기

namespace FinalProjectPOS
{
    class DataManager
    {
        public static List<Person> People = new List<Person>();//사람 클래스를 리스트로 만들어 줌 (리스트 이름 :People)
        
        static DataManager()//나는 데이터베이스를 모른다. 고로 Xml을 따라할 수밖에 없었다.
        {
            Load();
        }

        public static void Load()
        {
            try//예외처리하기
            {
                string peopleOutput = File.ReadAllText(@"./people.xml");//xml파일 만들기
                XElement peopleXElment = XElement.Parse(peopleOutput);
                People = (from item in peopleXElment.Descendants("person")
                          select new Person()
                          {
                              Name = item.Element("name").Value,
                              BirthDay = item.Element("birthday").Value,
                              PhoneNum = item.Element("phone").Value,
                              Payment = int.Parse(item.Element("payment").Value),
                              Time = int.Parse(item.Element("workingtime").Value),
                              Totalpay = int.Parse(item.Element("totalpay").Value)
                          }).ToList<Person>();
            }
            catch (FileNotFoundException exception)
            {
                Save();
            }
        }
        public static void Save()//저장
        {
            String peopleOutput = "";
            peopleOutput += "<Person>\n";
            foreach (var item in People)
            {
                peopleOutput += "<person>\n";//설마 이것 때문에 오류가 나는건가? => 수정
                peopleOutput += " <name>" + item.Name + "</name>\n";
                peopleOutput += " <birthday>" + item.BirthDay + "</birthday>\n";
                peopleOutput += " <phone>" + item.PhoneNum + "</phone>\n";
                peopleOutput += " <payment>" + item.Payment + "</payment>\n";
                peopleOutput += " <workingtime>" + item.Time + "</workingtime>\n";
                peopleOutput += " <totalpay>" + item.Totalpay + "</totalpay>\n";//분야별로 정보 저장하기
                peopleOutput += "</person>\n"; // 추가
            }
            peopleOutput += "</Person>\n";

            File.WriteAllText(@"./people.xml", peopleOutput);
        }
        }
    }