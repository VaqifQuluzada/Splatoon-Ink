using UnityEngine;

public class CollisionPainter : MonoBehaviour{
    public Color paintColor;
    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, radius);

	}

    private void OnCollisionStay(Collision other) {
        Paintable p = other.collider.GetComponent<Paintable>();
        if(p != null){
            Vector3 pos = other.contacts[0].point;
            PaintManager.Instance.Paint(p, pos, radius, hardness, strength, paintColor);
        }
    }
}
