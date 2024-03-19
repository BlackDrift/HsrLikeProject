using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsrLikeProject
{
    internal class Character
    {
        private int id;
        // characterType : 0 = dps, 1 = healer, 2 = support
        private int characterType;
        private string name;
        private int hp;
        private int atk;
        private int def;
        private int type;
        private bool alive;
        private int lvl;
        private int xp;
        private int energy;
        private CharacterSkill[3] skillList;

        private int itemBuffType;
        private Dictionary<int, string> types = new Dictionary<int, string>()
        {
            { 0, "physique" },
            { 1, "feu" },
            { 2, "glace" },
            { 3, "foudre" },
            { 4, "vent" },
            { 5, "quantique" },
            { 6, "imaginaire" }
        };
        private struct CharacterSkill
        {
            // attackType : ST = 0, Blast = 1, AoE = 2, Buff = 3, Heal = 4, Shield = 5
            public int attackType;
            public float multiplier;
            public string name;
            public string desc;
        }

        public Character(int cId, int cCharaType, string cName, int cHp, int cAtk, int cDef, int cType, bool cAlive, int cLvl, int cXp, int cEnergy, CharacterSkill[3] cSkillList)
        {
            id = cId;
            characterType = cCharaType;
            name = cName;
            hp = cHp;
            atk = cAtk;
            def = cDef;
            type = cType;
            alive = cAlive;
            lvl = cLvl;
            xp = cXp;
            energy = cEnergy;
            skillList = cSkillList;
        }

        public List<Character> createCharacters()
        {
            List<Character> characterList;

            // Dan Heng

            CharacterSkill danHengNormal;
            danHengNormal.attackType = 0;
            danHengNormal.multiplier = 0.8;
            danHengNormal.name = "North Wind";
            danHengNormal.desc = "Inflige des dégats de vent équivalent à 80% de l'atk de Dan Heng à une cible unique";

            CharacterSkill danHengTec;
            danHengTec.attackType = 0;
            danHengTec.multiplier = 2.6;
            danHengTec.name = "Torrent";
            danHengTec.desc = "Inflige des dégats de vent équivalent à 260% de l'atk de Dan Heng à une cible unique";

            CharacterSkill danHengUlt;
            danHengUlt.attackType = 0;
            danHengUlt.multiplier = 4.4;
            danHengUlt.name = "Ethereal Dream";
            danHengUlt.desc = "Inflige des dégats de vent équivalent à 440% de l'atk de Dan Heng à une cible unique";

            CharacterSkill[] danHengSkills = [danHengNormal, danHengTec, danHengUlt];

            Character danHeng = new Character(0, 0, "Dan Heng", 120, 74, 54, 4, true, 1, 0, 0, danHengSkills);

            characterList.Add(danHeng);

            // Jing Yuan

            CharacterSkill jingYuanNormal;
            danHengNormal.attackType = 0;
            danHengNormal.multiplier = 0.8;
            danHengNormal.name = "";
            danHengNormal.desc = "";

            CharacterSkill danHengTec;
            danHengTec.attackType = 0;
            danHengTec.multiplier = 2.6;
            danHengTec.name = "";
            danHengTec.desc = "";

            CharacterSkill danHengUlt;
            danHengUlt.attackType = 0;
            danHengUlt.multiplier = 4.4;
            danHengUlt.name = "";
            danHengUlt.desc = "";

            CharacterSkill[] danHengSkills = [danHengNormal, danHengTec, danHengUlt];

            Character danHeng = new Character(0, 0, "Jin Yuan", 120, 74, 54, 4, true, 1, 0, 0, danHengSkills);

            characterList.Add(danHeng);

            // Seele
            // Yanqing
            // Acheron
            // Trailblazer
            // March 7th
            // Aventurine
            // Gepard
            // Tingyun
            // Asta
            // Hanya
            // Natasha
            // Luocha
            // Lynx

            return characterList;
        }
    }
}
