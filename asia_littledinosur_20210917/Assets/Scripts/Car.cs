using UnityEngine;    //引用Unity引擎命名單行註解
public class Car :MonoBehaviour
{
    #region 
    public int cc =1000;
    [Range(1,10)]
    public float weight =3.5f;
    [Tooltip("這是車子的品牌")]
    public string brand ="BENZ";
    [Header("是否有天窗")]
    public bool hasSkywindows =true;
    #endregion
    #region Unity內資料類型
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    #endregion
}