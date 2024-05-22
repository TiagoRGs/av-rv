using UnityEngine;

[ExecuteInEditMode] // Isso permite que o script seja executado durante a edição
public class SphereWall : MonoBehaviour
{
    public float radius = 5f; // Raio da esfera
    public int segments = 30; // Número de segmentos

    void Awake()
    {
        GenerateSphere(); // Chama o método para gerar a esfera
    }

    void GenerateSphere()
    {
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();
        if (meshFilter == null)
        {
            meshFilter = gameObject.AddComponent<MeshFilter>();
        }
        Mesh mesh = meshFilter.sharedMesh;
        if (mesh == null)
        {
            mesh = new Mesh();
            meshFilter.sharedMesh = mesh;
        }
        mesh.Clear();

        Vector3[] vertices = new Vector3[(segments + 1) * (segments + 1)];
        int[] triangles = new int[segments * segments * 6];
        Vector2[] uv = new Vector2[vertices.Length];

        int index = 0;
        for (int i = 0; i <= segments; i++)
        {
            for (int j = 0; j <= segments; j++)
            {
                float theta = (float)i / segments * Mathf.PI;
                float phi = (float)j / segments * Mathf.PI * 2;

                float x = Mathf.Sin(theta) * Mathf.Cos(phi);
                float y = Mathf.Cos(theta);
                float z = Mathf.Sin(theta) * Mathf.Sin(phi);

                vertices[i * (segments + 1) + j] = new Vector3(x, y, z) * radius;
                uv[i * (segments + 1) + j] = new Vector2((float)j / segments, (float)i / segments);

                // Cria os triângulos
                if (i < segments && j < segments)
                {
                    triangles[index++] = i * (segments + 1) + j;
                    triangles[index++] = (i + 1) * (segments + 1) + j;
                    triangles[index++] = i * (segments + 1) + j + 1;

                    triangles[index++] = (i + 1) * (segments + 1) + j;
                    triangles[index++] = (i + 1) * (segments + 1) + j + 1;
                    triangles[index++] = i * (segments + 1) + j + 1;
                }
            }
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mesh.RecalculateNormals();
    }
}
