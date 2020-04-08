using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Fact : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fact;
    
    string[] allfacts = new[] { "Saving energy can be as simple as switching from incandescent light bulbs to CFL or LED versions.", "Geothermal energy comes from the Earth. It consists of hot water and hot rock that’s just a few miles beneath the Earth’s surface, and can go even deeper to very hot molten rock called magma. It’s considered clean and sustainable. ",
    "An estimated 15 trillion watts of power are being used across our planet at any one time", "One hour’s worth of energy from the sun could power the Earth for a year","48 people riding bikes for 24 hours can generate enough power to run a TV for a week ","Googling uses more energy than you think: the energy it takes to conduct ten searches on Google could power a 60-watt light bulb. At any one time the energy used by the search engine could power 200,000 homes. ","LED bulbs are the most efficient light bulbs and use about 90% less energy than other bulbs. You can save over $100 on energy bills over the bulb’s lifetime. ","It is estimated that the Energy star label, a program that promotes energy efficient appliances and products has helped save more than $430 billion on energy bills and reduced carbon emissions by 2.7 billion metric tons. That is the equivalent carbon emission of 670 coal power plants in a year! ","Only 5% of energy drawn from a phone charger is used to charge the phone. Chargers use energy as long as they are plugged into a power source so 95% of the energy is wasted. ","Every year, 171 Kgs of CO2 is released into the atmosphere just by leaving on unneeded/unused lights around our homes and offices ","About 30% of an average household energy bill is made up wasted energy. Windows, doors and fireplaces not sealed properly cause heat to escape through the cracks. ",
        "A microwave uses about 50% less energy as compared to an oven. Conserve energy: have pizzas! ","Approximately, 75% of electricity used to power home electronics is consumed while the products are supposedly ‘off’ (in standby mode). Televisions consume a lot of energy when turned off which is used in the instant working of the T.V so we don’t have to wait for a minute or two for it to start soon as we switch it on. ",
        "From 2008 to 2030, world energy consumption is expected to increase more than 55%" ,"According to Google, the energy it takes to conduct 100 searches on its site is equivalent to a 60-watt light bulb burning for 28 minutes. Google uses about 0.0003 kWh of energy to answer the avenge search query, which translates into about 0.2 g of carbon dioxide released" ,
        "The United States produces half of its electricity from coal. China uses coal to generate more than three-fourths of its electricity. Australia, Poland, and South Africa produce an even greater percentage. Overall, coal makes up 2/5 of the world’s electricity generation. ","The United States produces more nuclear-generated electricity than any other country, nearly 1/3 of the world’s total. The second largest producer is France, which generates more than 3/4 of its electricity in nuclear reactors. ",
        "One ceiling fixture can use $2,000 to $5,000 of electricity over its useful life. ","Thomas Edison built the first power plant, and in 1882 his Pearl Street Power Station sent electricity to 85 buildings. People were initially afraid of electricity and parents would not let their children near the lights. ",
        "A “watt” is a unit of power that measures the rate of producing or using energy. The term was named after Scottish engineer James Watt (1736-1819), who developed an improved steam engine. Watt measured his engine’s performance in horsepower. One horsepower equalled 746 watts. ",
        "The word “energy” comes from the Greek energeia, meaning operation, activity. ","If a person yelled for 8 years, 7 months, and 6 days, he or she would produce enough energy to heat one cup of coffee ","A hurricane releases 50 trillion to 200 trillion watts of heat energy. This is as much energy as a 10-megaton nuclear bomb exploding every 20 minutes. " };
    // Start is called before the first frame update
    void Start()
    {
        fact.text = allfacts[Random.Range(0,allfacts.Length-1)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
