
using PrototypeVillain;
using PrototypeVillain.Villains;

Kang kang1 = new();
kang1.Name = "Victor";
kang1.Power = new Power("Teletransporte");
kang1.TemporaryRealityNumber = 1;

Villain kang2 = new Kang();
kang2 = kang1.DeepCopy();
kang2.Name = "Aquele Que Permanece ";
kang2.TemporaryRealityNumber = 2;

Scrull scrull1 = new Scrull();
scrull1.Name = "Gravik";
scrull1.Power = new Power("Super Poderes");
scrull1.TemporaryRealityNumber = 1;

Villain scrull2 = new Scrull();
scrull2 = scrull1.ShallowCopy();
scrull2.Name = "Kang";
scrull1.Power = new Power("Mudar de Forma");

Villain scrull3 = new Scrull();
scrull3 = scrull1.DeepCopy();
scrull3.Name = "Kree-Skrull";
scrull3.TemporaryRealityNumber = 3;


kang1.PrintDescricao();
kang2.PrintDescricao();

scrull1.PrintDescricao();
scrull2.PrintDescricao();
scrull3.PrintDescricao();
