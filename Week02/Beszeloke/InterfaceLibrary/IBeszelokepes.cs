using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public interface IBeszelokepes
    {
        string Beszelj(); //interfészek esetén minden metódus publikus, nem kell külön odaírni
        // {}-et nem tartalmazhat! csak szignatúra (visszatérési érték típusa, függvénynév, paraméterlista) szerepelhet az interfészben
    }
}
