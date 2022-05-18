using Assets.Scripts;
using Assets.Scripts.GameplayComponents;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class ConfigGenerator
{
    public void GenerateCompanies()
    {
        Dictionary<int, Company> companies = new Dictionary<int, Company>()
        {
            {1, new Company("Microsoft",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {2, new Company("Apple",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {3, new Company("Samsung", ETypeOfCompany.IT,new PriceComponent(400,400))},
            {4, new Company("IBM",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {5, new Company("Accenture",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {6, new Company("Oracle",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {7, new Company("Hawlett Packard",ETypeOfCompany.IT,new PriceComponent(400,400))},
            {8, new Company("McDonalds",ETypeOfCompany.Food,new PriceComponent(400,400))},
            {9, new Company("Burger King",ETypeOfCompany.Food,new PriceComponent(400,400))},
            {10, new Company("KFC",ETypeOfCompany.Food,new PriceComponent(400,400))},
            {11, new Company("The North Face",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {12, new Company("Nike",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {13, new Company("Adidas",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {14, new Company("Reebok",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {15, new Company("Levis",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {16, new Company("Carhart",ETypeOfCompany.Clothes,new PriceComponent(400,400))},
            {17, new Company("Johnson & Johnson",ETypeOfCompany.Medicine,new PriceComponent(400,400))},
            {18, new Company("Pfizer",ETypeOfCompany.Medicine,new PriceComponent(400,400))},
            {19, new Company("Roche",ETypeOfCompany.Medicine,new PriceComponent(400,400))},
            {20, new Company("Novartis",ETypeOfCompany.Medicine,new PriceComponent(400,400))},
            {21, new Company("Bayer",ETypeOfCompany.Medicine,new PriceComponent(400,400))},
            {22, new Company("Nasa",ETypeOfCompany.Inventions,new PriceComponent(400,400))},
            {23, new Company("Boeing Company",ETypeOfCompany.Inventions,new PriceComponent(400,400))},
            {24, new Company("Disney",ETypeOfCompany.Movies,new PriceComponent(400,400))},
            {25, new Company("Sony",ETypeOfCompany.Movies,new PriceComponent(400,400))},
            {26, new Company("Nestle",ETypeOfCompany.Food,new PriceComponent(400,400))},
        };
        new SaveInfo().GenerateCompaniesInfo(companies);
    }
    public void GenerateHeadlines()
    {
        List<Headline> headlines = new List<Headline>()
        {
            new Headline("*** �������� � ������� � ����� � �� ��������� ������������ �������� ",-7),
            new Headline("*** �������� ����������������� �����. ��� ������������ ������ ������ �� ��������� ������� �����.",7),
            new Headline("*** ��������� ����.",5),
            new Headline("*** ����� ������ ��-�� ������� ������������ ��������.",-15),
            new Headline("��� ��������� *** ������� � ������������� ����������. ���� �������� �������.",-30),
            new Headline("��� ��������� *** ������� � �������� �������. ���� �������� �������.",-20),
            new Headline("��� ��������� *** ������� � ���������������. ���� �������� �������.",-25),
            new Headline("��� �������� *** ����� � ������.",-20),
            new Headline("*** �������� �������� �� ��������� ����������.",+7),
            new Headline("*** ����� ������� � ����� � ��������� �������� ���������.",+7),
            new Headline("*** ����� ������ � ����� � �������� ������.",-12),
            new Headline("*** �������������� ����������. ��� ������� ����� �������� ***.",50),
            new Headline("*** ����� ������ � ����� � �������� ������.",-25),
            new Headline("��������� ������� ����� �������� ***.",30)
        };
        new SaveInfo().GenerateHeadlineInfo(headlines);
    }
    public void GenerateOcassions()
    {
        List<FriendOcassion> ocassions = new List<FriendOcassion>()
        {
            new FriendOcassion("��������","������ �����, ���������� ��� ������, �� �� ���������.",500),
            new FriendOcassion("������","�����, ������� � ���� �������",-200),
            new FriendOcassion("�����","��, �� ��� �� ������ �� ���� � ������ ���� �������� �������)",-300),
            new FriendOcassion("���������","������, ����� ���� � ������� \n �� ������ ����������?)",-100),
            new FriendOcassion("��������","������ ����, �� ���������� �� ����������������� �����\n ���� �����������.",-100),
            new FriendOcassion("mchs.gov.by","��������� ������������ �������� �����. ������ ����������� �\n ���������!",-250),
            new FriendOcassion("����������","�����������! �� �������� � �������! ��������� �� ������ http://LuckyLotery.ly/",-500),
            new FriendOcassion("BPSSBERBANK","������ ���� ������ ��������, ��� ���� � ����� ��� ���������\n �� ����� �������� �� ������ �������, �������� ���� ��������� ��\n ��������������� ���������� ��� �����������.",-200),
            new FriendOcassion("����������","������, � ������� ���� � ������ ���� ��� ��� ����, ������ ��\n �������� ������ ����� ��� ���� ����, ��� ������� ������ �� ������-\n���� ������ ����: 1234 5678 9012 3456 � ��� ������",-200),
            new FriendOcassion("��������","������ ����, � ��� �������� ����� �������: ���'IDeveloper'.\n ���������� ���� ���� �����.",+500),
            new FriendOcassion("�����������","������, ���� �������� ����� \n ������������? ",-50),
            new FriendOcassion("������","�����, �� ������ �� ����� ����������?",-50),
            new FriendOcassion("����","������ �����, ������ ��������� ��������, ��� ��������\n ��� �� �� ������ ��������� � �������.",-100),
        };
        new SaveInfo().GenerateOcassionsInfo(ocassions);
    } 
}
