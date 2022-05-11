using Assets.Scripts;
using Assets.Scripts.News;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SubjectGenerator
{
    public Subject GetSubject(Dictionary<int, Company> companies, List<Headline> headlines)
    {
        int a = Random.Range(1, companies.Count);
        Company company = default;
        try
        {
            company = companies.First(x => x.Key == a).Value;
        }
        catch (System.Exception)
        {
            Debug.Log(a);
        }
        Headline currentHeadline = headlines[Random.Range(0, headlines.Count-1)];
        if (currentHeadline is TypedHeadline)
        {
            TypedHeadline typedHeadline = currentHeadline as TypedHeadline;
            while (typedHeadline.Type != company.Type)
            {
                currentHeadline = headlines[Random.Range(0, headlines.Count-1)];
                typedHeadline = currentHeadline as TypedHeadline;
            }
        }
        return new Subject(company, currentHeadline);
    }
}
