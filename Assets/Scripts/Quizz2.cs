using UnityEngine;

public class Quizz2 : MonoBehaviour
{
    public Transform player;　// Harukoモデルを格納した変数

    void Update()
    {
 
        if (Input.GetMouseButtonDown(0)) // 左クリックされたら
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                player.position = hit.point;

                // 接触したオブジェクトがTerrain Colliderだった場合
                if (hit.collider is TerrainCollider)
                {
                    // 接触点からのTerrainの法線ベクトルを取得
                    Vector3 terrainNormal = hit.normal;

                    // Harukoの上方向を調整して垂直に立つようにする
                    player.up = terrainNormal;
                }
            }
        }
    }
}
