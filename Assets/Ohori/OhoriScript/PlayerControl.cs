using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("CountDownTime"))//CountDownTime‚Æ‚¢‚¤ƒ^ƒO‚ª‚ ‚é‚Æ‚«
        {
            var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
            var dv = 4f * Time.deltaTime * direction;
            this.transform.Translate(dv.x, dv.y, 0f);
        }
    }
}
