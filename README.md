# AA-2702
### **Algoritma Karmaşıklığı: Ω (Omega) ve Θ (Teta) Notasyonları**

Algoritma analizi, bir algoritmanın verimli olup olmadığını anlamamızı sağlar. Big-O (O), Omega (Ω) ve Theta (Θ) notasyonları, algoritmaların en iyi, en kötü ve ortalama çalışma sürelerini ifade eder. Bu dökümanda Ω ve Θ notasyonlarını ele alacağız ve bunları açıklayan C# kodlarını paylaşacağız.


---

# **1️⃣ Ω (Omega) Notasyonu – En İyi Durumun Alt Sınırı**

Ω notasyonu, bir algoritmanın en az ne kadar hızlı çalışabileceğini gösterir. Alt sınır (lower bound) olarak da bilinir.

Örneğin, Lineer Arama (Linear Search) algoritmasını ele alalım:

En iyi durumda (Ω(1)), aranan eleman dizinin başında olabilir.

En kötü durumda (O(n)), elemanı bulmak için tüm liste taranabilir.


**Kod örneği:**

using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // En iyi durum: Ω(1)
        }
        return -1; // En kötü durum: O(n)
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int result = LinearSearch(arr, 30);
        Console.WriteLine(result); // 2 döner
    }
}

Sonuç:

En iyi durumda: Ω(1) (eleman baştaysa)

En kötü durumda: O(n) (eleman en sonda veya yoksa)



---

# **2️⃣ Θ (Teta) Notasyonu – Sıkı Sınır**

Θ notasyonu, hem en iyi hem de en kötü durumda çalışma süresi aynı olan algoritmalar için kullanılır. Yani ortalama performansı tam olarak belirler.

Örneğin, Merge Sort (Birleştirme Sıralaması) algoritması her zaman Θ(n log n) zaman karmaşıklığında çalışır.

**Kod örneği:**

using System;

class Program
{
    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }

    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        MergeSort(arr);
        Console.WriteLine(string.Join(", ", arr)); // Sıralı hali ekrana basar
    }
}

Sonuç:

Her durumda: Θ(n log n)

Böl ve yönet (divide and conquer) yaklaşımıyla çalışır.

Kötü durumda bile Θ(n log n) çalışır.



---

**Özet**


Ω(omega), algoritmanın en az ne kadar sürede çalışabileceğini gösterir.

Θ(theta), algoritmanın her zaman ne kadar sürede çalıştığını gösterir.

O (big-O), en kötü durumu ifade eder (bu dökümanda detayına girilmedi).
