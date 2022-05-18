# **Wordle**


### **Установка**
Для того, щоб запустити програму 
потрібно установити Visual Studio і C#, **створити папку "Wordle"
на диску 'D'** та розархівувати усі файли туди.
Потім, потрібно зайти в папку Wordle -> bin -> Debug -> Wordle.exe.
Правила є у самій грі.
Якщо у вас створилася папка "Wordle-main", то вам потрібно її знищити
В кінцевому форматі має бути такий шлях: **D:\Wordle\Wordle\valid-wordle-words.txt**

### P.S.
Якщо у вас немає диску 'D', потрібно при установці на будь-який інший диск зайти в папку Wordle -> Wordle.sln, та замінити шлях до файлу на ваш шлях
```c#
    StreamReader fi = new StreamReader(@"D:\Wordle\Wordle\valid-wordle-words.txt");
```
#### P.S.
Краще не використовувати шлях з кирилицею, так як C# не любить це :-)
____

### **Основні команди та цикли**

####  **Вибір слова**

```c#
    int i = 0;

            for (; i < 12972; i++)  
            {
                st[i] = fi.ReadLine(); //зчитуємо файли
            }
            Random rnd = new Random(); // створюємо нову змінну рандом
            int value = rnd.Next(0, i);
            correct_word = st[value]; // записуємо у змінну загадане слово 

```

#### **Перевірка дійсності слів та виклик допоміжних програм**


```c#
    bool match;
        match = false;
        int j = 0;
        while ( (j < 12972) && (match == false) ) 
        {
            if (st[j] == word1)
                {
                    match = true;
                }
            j++;
        }
        if (match == true)
        {
            Checking1();
        }
        else
        {
            Incorrect_word1();
        }
```

#### **Допоміжні програми**

+ Перефарбовування в жовтий
```c#
    for( i = 0; i < 5; i++)
        {
            if (textBox1.Text == Convert.ToString(correct_word[i]))
            {
                textBox1.BackColor = Color.Yellow;
            }     //ми перевіряємо першу букву в введеному слові
        }         //та співвідносимо її з усіма й шукаємо пару
```
+ Перефарбовування в зелений
```c#
    if (Convert.ToString(correct_word[0]) == textBox1.Text)
        {
            textBox1.BackColor = Color.Green;
        }   //якщо відповідна буква у введеному слові співпадає
            //з відповідною в загаданому, то ми зафарбовуємо її в зелений
```
+ У разі програшу або перемоги для останнього поля
```c#
if ((textBox26.BackColor == Color.Green) && (textBox27.BackColor == Color.Green) && (textBox28.BackColor == Color.Green) && (textBox29.BackColor == Color.Green) && (textBox30.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close(); 
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                var result1 = MessageBox.Show("Ви програли!" + " Загадане слово було " + correct_word, "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result1 == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result1 == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
```
+ Неправильно введене слово
```c#
MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
    textBox5.Clear();
    textBox4.Clear();
    textBox3.Clear();
    textBox2.Clear();
    textBox1.Clear();
    textBox1.ReadOnly = false;
    textBox2.ReadOnly = false;
    textBox3.ReadOnly = false;
    textBox4.ReadOnly = false;
    textBox5.ReadOnly = false;
```
___
### **Створення програми**
![logo](https://media.proglib.io/posts/2022/03/08/5f856cc9c6a79ead524a20aadc18fed7.jpg)
 + Програма повністю була створена мною та моїми двома руками, але також уваги заслуговуюють **TeamLead Наталія Григорівна** та невичерпний об'єм інформації **Google**

 + Основна мова **C#**

+ Основне серидовище **Visual studio**

![kartinka](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRc14m2UlGK_9-sdyr_RvMv_6Yaijrob3AOPW15QZBjJsg9jt5hHKRSC4qNWS_NC2AOOKY&usqp=CAU)


