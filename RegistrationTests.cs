using RegistrationApp_Test;

namespace RegistrationTest
{
    public class Tests
    {
        #region �������� �� ������� �����
        [Test]
        public void Test1()
        {
            var check = new CheckRegistrationData();
            var expected = "������� ����� � ������! ����������� ������!";

            var actual = check.UserInformation("","","");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test2()
        {
            var check = new CheckRegistrationData();
            var expected = "������� ����� � ������!";

            var actual = check.UserInformation("", "", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test3()
        {
            var check = new CheckRegistrationData();
            var expected = "������� ����� � ����������� ������!";

            var actual = check.UserInformation("", "password", "");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test4()
        {
            var check = new CheckRegistrationData();
            var expected = "������� �����!";

            var actual = check.UserInformation("", "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test5()
        {
            var check = new CheckRegistrationData();
            var expected = "������� ������ � ����������� ���!";

            var actual = check.UserInformation("login", "", "");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test6()
        {
            var check = new CheckRegistrationData();
            var expected = "������� ������!";

            var actual = check.UserInformation("login", "", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        public void Test7()
        {
            var check = new CheckRegistrationData();
            var expected = "����������� ������!";

            var actual = check.UserInformation("login", "password", "");

            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion

        #region �������� ������
        [TestCase("l")]
        [TestCase("lo")]
        [TestCase("log")]
        [TestCase("logi")]
        public void Test8(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "����� ������ ��������� ������� 5 ��������";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("log in@mail.ru")]
        [TestCase("login @mail.ru")]
        [TestCase("login @ mail.ru")]
        [TestCase("login@mail .ru")]
        [TestCase("��� ��@gmail.com")]
        [TestCase("�����@gmail. com")]
        [TestCase("����� @gmail.com")]
        [TestCase("�����@g mail.com")]
        public void Test9(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� �� ������ ��������� ��������. ����� ������ ���� ������� xxx@xxx.xxx";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("�����@gmail.com")]
        [TestCase("�����@gmail.")]
        public void Test10(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� ������ ��������� ������ ��������.";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("log?in@mail.ru")]
        [TestCase("login!@mail.ru")]
        [TestCase("log,in@mail.ru")]
        [TestCase("login@ma:il.ru")]
        [TestCase("l;ogin@mail.ru")]
        public void Test11(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� �� ������ ��������� ����� ����������.";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("log$in@mail.ru")]
        [TestCase("login@ma+il.ru")]
        public void Test12(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� �� ������ ��������� ��������.";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("login@mer.ci.nsu.")]
        public void Test13(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� ������ ��������� ����� �����. ����� ������ ���� ������� xxx@xxx.xxx";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("log.in@mail.ru")]
        [TestCase("com.gmail@login")]
        public void Test14(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "�������� ������ �����. ����� ������� ������ ������ ������ ���� ������ ������� ������. ����� ������ ���� ������� xxx@xxx.xxx";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("log in")]
        [TestCase("login ")]
        [TestCase(" login")]
        [TestCase("log in_1")]
        [TestCase("login 1")]
        [TestCase("12 34")]
        [TestCase("��� ��")]
        [TestCase(" �����")]
        [TestCase("����� ")]
        public void Test15(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "����� �� ������ ��������� ��������";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("+7965868571")]
        public void Test16(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "����� �������� ������ ���� � ������� +7-xxx-xxx-xxxx";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("+7-965-456-")]
        [TestCase("+7-965-")]
        public void Test17(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "����� ������ �������� �� 11 ����. ���������� ���� ������ 11";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("login")]
        [TestCase("login_")]
        [TestCase("login1")]
        [TestCase("12345")]
        [TestCase("+27665")]
        [TestCase("login!")]
        [TestCase("LOGIN")]
        [TestCase("LOGIN1")]
        [TestCase("LOGIN_")]
        [TestCase("!@#$%^")]
        [TestCase("�����")]
        public void Test18(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "C�������� ����� ������ ����� ������ ��������, ����� � ���� ������������� _";

            var actual = check.LoginVerification(login, "password", "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion

        #region �������� ������
        [TestCase("p")]
        [TestCase("pa")]
        [TestCase("pas")]
        [TestCase("pass")]
        [TestCase("passw")]
        [TestCase("passwo")]
        public void Test19(string password)
        {
            var check = new CheckRegistrationData();
            var expected = "������ ������ ��������� ������� 7 ��������";

            var actual = check.PasswordVerification("login_1", password, "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("pass word")]
        [TestCase("pas swo")]
        [TestCase("��� ���")]
        [TestCase(" passwo")]
        [TestCase("passwo ")]
        [TestCase("������ ")]
        [TestCase(" ������")]
        [TestCase("123 456")]
        [TestCase("@#$ %^&+")]
        public void Test20(string password)
        {
            var check = new CheckRegistrationData();
            var expected = "������ �� ������ ��������� ��������";

            var actual = check.PasswordVerification("login_1", password, "password");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("password")]
        [TestCase("password1")]
        [TestCase("password_")]
        [TestCase("password_1")]
        [TestCase("passWord")]
        [TestCase("passWord1")]
        [TestCase("passWord_")]
        [TestCase("passWord_1")]
        [TestCase("PASSWORD")]
        [TestCase("�Q�����")]
        [TestCase("�������")]
        [TestCase("������_")]
        [TestCase("������1")]
        [TestCase("�������")]
        [TestCase("�������_")]
        [TestCase("�������1")]
        [TestCase("�������")]
        [TestCase("�������")]
        [TestCase("������1")]
        [TestCase("������_")]
        [TestCase("1234567")]
        [TestCase("@#$%^&+=_.")]
        public void Test21(string password)
        {
            var check = new CheckRegistrationData();
            var expected = "������ ������ ��������� ������ ���������, ����� � �����������.\n����������� ����������� ������� ����� ����� � ������� � ������ ��������, ����� ����� � ������ ����������� @#$%^&+=_.";

            var actual = check.PasswordVerification("login_1", password, "password");

            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase("�������_1", "�������_2")]
        [TestCase("�������_1", "�������_1")]
        public void Test22(string password, string checkPas)
        {
            var check = new CheckRegistrationData();
            var expected = "������ � ������������� ������ �� ���������";

            var actual = check.PasswordVerification("login_1", password, checkPas);

            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion

        [TestCase("ivanovak01@mail.ru")]
        [TestCase("sergy5em@gmali.com")]
        [TestCase("+7-987-656-7676")]
        [TestCase("+7-944-772-0967")]
        [TestCase("+7-951-865-1390")]
        [TestCase("Evgeny_56")]
        [TestCase("Yuna5_w")]
        [TestCase("L1na_K1")]
        [TestCase("yul1na@mail.ru")]
        [TestCase("+7-932-814-2415")]
        public void Test23(string login)
        {
            var check = new CheckRegistrationData();
            var expected = "������ � ������������� ������ �� ���������";

            var actual = check.UserValidate(login, "������_1","������_1");

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}