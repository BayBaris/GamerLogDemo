using System;
using System.Collections.Generic;
using System.Text;
using GamerLogDemo.Entity;

namespace GamerLogDemo
{
    interface ICampaignService
    {
        void Calculate(List<Game> games);
        void ListGame(List<Game> games);
    }
}
