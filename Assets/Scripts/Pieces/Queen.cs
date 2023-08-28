using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override bool IsMovable(int posX, int posY)
    {
        throw new System.NotImplementedException();
    }
}
