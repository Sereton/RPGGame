using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToCompleteTheQuest = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToCompleteTheQuest.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 2));

            _quests.Add(new Quest(1, "Mata a marimar", "Find Herr Schmolz at SussingStrasse", itemsToCompleteTheQuest, 25, 10, rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
