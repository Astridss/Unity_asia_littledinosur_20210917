using UnityEngine;    //�ޥ�Unity�����R�W������
public class Car :MonoBehaviour
{
    #region 
    public int cc =1000;
    [Range(1,10)]
    public float weight =3.5f;
    [Tooltip("�o�O���l���~�P")]
    public string brand ="BENZ";
    [Header("�O�_���ѵ�")]
    public bool hasSkywindows =true;
    #endregion
    #region Unity���������
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    #endregion
}