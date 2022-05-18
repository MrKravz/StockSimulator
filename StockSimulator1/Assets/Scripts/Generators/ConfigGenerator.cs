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
            new Headline("*** обвинили в расизме в связи с их последней коммерческой рекламой ",-7),
            new Headline("*** проводят благотворительный вечер. Все заработанные деньги пойдут на поддержку детских домов.",7),
            new Headline("*** расширяет штат.",5),
            new Headline("*** несет убытки из-за сложной политической ситуации.",-15),
            new Headline("Ген директора *** уличили в коррупционных махинациях. Идет судебный процесс.",-30),
            new Headline("Ген директора *** уличили в неуплате налогов. Идет судебный процесс.",-20),
            new Headline("Ген директора *** уличили в домогательствах. Идет судебный процесс.",-25),
            new Headline("Ген директор *** погиб в аварии.",-20),
            new Headline("*** проводит компанию по поддержке меньшинств.",+7),
            new Headline("*** несет прибыль в связи с недавними успехами продукции.",+7),
            new Headline("*** несет убытки в связи с вспышкой вируса.",-12),
            new Headline("*** заинтересовала инвесторов. Они скупают акции компании ***.",50),
            new Headline("*** несет убытки в связи с вспышкой вируса.",-25),
            new Headline("Реддиторы скупают акции компании ***.",30)
        };
        new SaveInfo().GenerateHeadlineInfo(headlines);
    }
    public void GenerateOcassions()
    {
        List<FriendOcassion> ocassions = new List<FriendOcassion>()
        {
            new FriendOcassion("Директор","Добрый вечер, перечислил вам премию, вы ее заслужили.",500),
            new FriendOcassion("Серега","Даров, погнали в клуб сегодня",-200),
            new FriendOcassion("Даник","Эт, ты там не хочешь со мной в казино пару ставочек сделать)",-300),
            new FriendOcassion("Елизавета","Привет, нашла тебя в тиндере \n Не против пообщаться?)",-100),
            new FriendOcassion("Директор","Добрый день, вы приглашены на благотворительный вечер\n Явка обязательна.",-100),
            new FriendOcassion("mchs.gov.by","Ожидается значительное усиление ветра. Будьте внимательны и\n осторожны!",-250),
            new FriendOcassion("Неизвестен","Поздравляем! Вы выйграли в лотерее! Перейдите по ссылке http://LuckyLotery.ly/",-500),
            new FriendOcassion("BPSSBERBANK","Добрый день Никита Игоревич, ваш счет в банке был заморожен\n на время проверки по уплате налогов, приносим свои извинения за\n предоставленные неудобства ваш БПССберБанк.",-200),
            new FriendOcassion("Неизвестен","Привет, я взломал тебя и теперь знаю все про тебя, можешь не\n пытаться узнать номер или типо того, мои условия просты ты перево-\nдишь деньги сюда: 1234 5678 9012 3456 Я все удаляю",-200),
            new FriendOcassion("Директор","Добрый день, у нас появился новый спонсор: ООО'IDeveloper'.\n Перечисляю тебе твою часть.",+500),
            new FriendOcassion("Криситночка","Привет, меня Кристина зовут \n Познакомимся? ",-50),
            new FriendOcassion("Ромчик","Даров, не хочешь на тачке покататься?",-50),
            new FriendOcassion("Врач","Добрый вечер, пришли резултаты анализов, они удручают\n Вам бы не мешало подъехать в болницу.",-100),
        };
        new SaveInfo().GenerateOcassionsInfo(ocassions);
    } 
}
