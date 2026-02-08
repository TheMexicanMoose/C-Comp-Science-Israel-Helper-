namespace TestLib.TreeLib;
using Unit4.CollectionsLib;

public class TreeLib
{
    // יוצרת עץ בינארי ממערך לפי סדר סדרות
    // מקבלת: מערך, אינדקס התחלתי
    // מחזירה/עושה: ראש העץ הבינארי
    // סיבוכיות: O(n)
    public static BinNode<T> CreateTree<T>(T[] arr, int index = 0)
    {
        if (index >= arr.Length)
            return null!;

        BinNode<T> root = new BinNode<T>(arr[index]); // יצירת צומת ראשית
        root.SetLeft(CreateTree(arr, 2 * index + 1)); // יצירת תת עץ שמאלי
        root.SetRight(CreateTree(arr, 2 * index + 2));// יצירת תת עץ ימני
        return root;
    }

    // סריקה פרה-אורדר (Node-Left-Right)
    // מקבלת: ראש העץ, פעולה לביצוע על כל צומת
    // מחזירה/עושה: מבצעת פעולה על כל הצמתים לפי סדר
    // סיבוכיות: O(n)
    public static void Scan1<T>(BinNode<T> root, Action<T> action)
    {
        if (root == null!) return;                   // בדיקה אם הצומת ריקה
        action(root.GetValue());                    // ביצוע הפעולה על הצומת הנוכחית
        Scan1(root.GetLeft(), action);             // סריקה של תת העץ השמאלי
        Scan1(root.GetRight(), action);            // סריקה של תת העץ הימני
    }

    // סריקה אין-אורדר (Left-Node-Right)
    // מקבלת: ראש העץ, פעולה לביצוע על כל צומת
    // מחזירה/עושה: מבצעת פעולה על כל הצמתים לפי סדר
    // סיבוכיות: O(n)
    public static void Scan2<T>(BinNode<T> root, Action<T> action)
    {
        if (root == null!) return;                   
        Scan2(root.GetLeft(), action);             
        action(root.GetValue());                    
        Scan2(root.GetRight(), action);            
    }

    // סריקה פוסט-אורדר (Left-Right-Node)
    // מקבלת: ראש העץ, פעולה לביצוע על כל צומת
    // מחזירה/עושה: מבצעת פעולה על כל הצמתים לפי סדר
    // סיבוכיות: O(n)
    public static void Scan3<T>(BinNode<T> root, Action<T> action)
    {
        if (root == null!) return;                   
        Scan3(root.GetLeft(), action);             
        Scan3(root.GetRight(), action);            
        action(root.GetValue());                    
    }

    // מחזירה את מספר הצמתים בעץ
    // מקבלת: ראש העץ
    // מחזירה/עושה: מספר הצמתים
    // סיבוכיות: O(n)
    public static int LengthBt<T>(BinNode<T> root)
    {
        if (root == null!) return 0;                 
        return 1 + LengthBt(root.GetLeft()) + LengthBt(root.GetRight());
    }

    // מחזירה את סכום הערכים בעץ (לעץ מסוג int)
    // מקבלת: ראש העץ
    // מחזירה/עושה: סכום הערכים
    // סיבוכיות: O(n)
    public static int SumBt(BinNode<int> root)
    {
        if (root == null!) return 0;
        return root.GetValue() + SumBt(root.GetLeft()) + SumBt(root.GetRight());
    }

    // בודק אם ערך קיים בעץ
    // מקבלת: ראש העץ, ערך לחיפוש
    // מחזירה/עושה: true אם הערך קיים, אחרת false
    // סיבוכיות: O(n)
    public static bool IsExistBt<T>(BinNode<T> root, T value)
    {
        if (root == null!) return false;           
        if (root.GetValue()!.Equals(value)) return true;
        return IsExistBt(root.GetLeft(), value) || IsExistBt(root.GetRight(), value);
    }

    // בודק אם שני עצים בינאריים זהים
    // מקבלת: שני ראשים של עצים
    // מחזירה/עושה: true אם שווים בגודל ובערכים, אחרת false
    // סיבוכיות: O(n)
    public static bool IsEqualBTs<T>(BinNode<T> root1, BinNode<T> root2)
    {
        if (root1 == null! && root2 == null!) return true;  
        if (root1 == null || root2 == null!) return false; 
        if (!root1.GetValue()!.Equals(root2.GetValue())) return false;

        return IsEqualBTs(root1.GetLeft(), root2.GetLeft()) &&
               IsEqualBTs(root1.GetRight(), root2.GetRight());
    }

    // מחזירה את גובה העץ (מספר הרמות)
    // מקבלת: ראש העץ
    // מחזירה/עושה: מספר רמות
    // סיבוכיות: O(n)
    public static int Height<T>(BinNode<T> root)
    {
        if (root == null!) return -1;                   
        return 1 + Math.Max(Height(root.GetLeft()), Height(root.GetRight()));
    }

    // סופר כמה עלים יש בעץ
    // מקבלת: ראש העץ
    // מחזירה/עושה: מספר העלים
    // סיבוכיות: O(n)
    public static int CountLeaves<T>(BinNode<T> root)
    {
        if (root == null!) return 0;                 
        if (root.GetLeft() == null && root.GetRight() == null) return 1; 
        return CountLeaves(root.GetLeft()) + CountLeaves(root.GetRight());
    }
}
