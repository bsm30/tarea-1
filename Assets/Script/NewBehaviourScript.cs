using UnityEngine;
using Mitienda;
using System;

public class NewBehaviourScript : MonoBehaviour
{

    static Consolas[] consolas;

    static Juegos[] juegos;

    static float total;

    // Start is called before the first frame update
    void Start()
    {

        consolas = new Consolas[8];

        consolas[0] = new Ps4("Playstation 4 - ", Ps4.Type.Playstation_4, 1800);

        consolas[1] = new Ps4("Playstation 1 - ", Ps4.Type.Playstation_1, 340);

        consolas[2] = new Ps4("Playstation 2 - ", Ps4.Type.Playstation_2, 1000);

        consolas[3] = new Xbox("Xbox 360 - ", Xbox.Type.Xbox_360, 1000);

        consolas[4] = new Xbox("Xbox One - ", Xbox.Type.Xbox_one, 1036);

        consolas[5] = new Nintendo("Nintendo 64 - ", Nintendo.Type.Nintendo_64, 130);

        consolas[6] = new Nintendo("Nintendo 3DS - ", Nintendo.Type.Nintendo_3DS, 278);

        consolas[7] = new Nintendo("Nintendo switch - ", Nintendo.Type.Nintendo_Switch, 1500);

        juegos = new Juegos[6];

        juegos[0] = new Digital("Assasins Creed 3 - ", Digital.Plataforma.Playstation_Store, 130);

        juegos[1] = new Fisico("Dragon ball - ", Fisico.Local.MasGamer, 150);

        juegos[2] = new Digital("Animal Crossing - ", Digital.Plataforma.Eshop, 200);

        juegos[3] = new Fisico("Smash - ", Fisico.Local.Phantom, 150);

        juegos[4] = new Digital("Halo - ", Digital.Plataforma.Xbox_Store, 150);

        juegos[5] = new Fisico("Halo 2 - ", Fisico.Local.MasGamer, 160);


        Loop();
        


    }

    void Loop()
    {

        for (int i = 0; i < consolas.Length; i++)

            Debug.Log("\t" + (1 + i) + " - " + consolas[i].nombre + "S/." + consolas[i].precio);

        for (int i = 0; i < juegos.Length; i++)

            Debug.Log("\t" + (9 + i) + "  - " + juegos[i].nombre + "S/." + juegos[i].precio);

        total += consolas[2].precio;

        total += juegos[2].precio;

        Debug.Log("total :" + total);
    }
}
