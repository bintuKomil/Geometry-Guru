<<<<<<< HEAD
=======
# Geometry-Guru
>>>>>>> 649a0f3e6c4450403d0b2fd0b71fd99e9a969500
📐 Geometry Guru — C# Konsol Dasturi

Geometry Guru — bu turli geometrik figuralarning yuzalarini hisoblaydigan va uchburchaklar bilan ishlash uchun qulay menyuga ega bo‘lgan C# konsol dasturi.

Dastur quyidagilarni hisoblay oladi:

Aylana yuzasi

To‘g‘ri to‘rtburchak yuzasi

Uchburchak yuzasi (Heron formulasi bilan)

Asos va balandlik orqali uchburchak yuzasi

Ikkita tomon berilganda uchinchi tomonning mumkin bo‘lgan oraliqlari

🚀 Ishga tushirish

Kodni kompyuteringizga .cs fayl sifatida saqlang (masalan: Program.cs).

Terminal/CMD oching.

Quyidagilarni yozing:

csc Program.cs
./Program


Yoki Visual Studio / Rider / VS Code orqali odatdagidek Run qiling.

📋 Dastur menyusi

Dastur ishga tushganda quyidagi menyu ko‘rinadi:

=== Geometry Guru ===
1. Aylana yuzasi
2. To'g'ri to'rtburchak yuzasi
3. Uchburchak - hisoblash va tomon oraliqlari
4. Chiqish

🧮 Funksiyalar haqida qisqacha
1️⃣ Aylana yuzasi

Formula:

S = π * r²


Dastur radiusni (r) kiritishingizni so‘raydi va yuzani hisoblaydi.

2️⃣ To‘g‘ri to‘rtburchak yuzasi

Formula:

S = a * b


Foydalanuvchi ikki tomon uzunligini kiritadi.

3️⃣ Uchburchak bo‘limi

Bu bo‘limda 3 ta kichik menyu mavjud:

✔ 3.1. Uch tomon bo‘yicha (Heron formulasi)
s = (a + b + c) / 2
S = √(s(s-a)(s-b)(s-c))


Tomonlar uchburchak shartiga mos kelmasa, dasturning o‘zi xabar beradi.

✔ 3.2. Asos va balandlik bo‘yicha
S = 1/2 * b * h

✔ 3.3. Ikkita tomon berilganda uchinchi tomon oraliqlari

Uchburchak mavjud bo‘lishi uchun:

|a - b| < t < a + b


Dastur ushbu oraliqni chiqarib beradi

foydalanuvchi xohlasa t qiymatini tekshirib ko‘rishi mumkin.

🔢 Son kiritish formati

Dastur barcha lokalizatsiyalar uchun moslashtirilgan:

12.5 (nuqta bilan)

12,5 (vergul bilan)

Ikkalasi ham to‘g‘ri ishlaydi.

🔧 Texnik imkoniyatlar

ReadDouble() funksiyasi noto‘g‘ri formatlarni qayta kiritishni so‘raydi

Har bir bo‘limdan so‘ng ENTER bosib davom ettirish mumkin

Manfiy yoki noto‘g‘ri qiymatlarda batafsil ogohlantirishlar mavjud

<<<<<<< HEAD
Uchburchakning degenerat holatlarini aniqlaydi
=======
Uchburchakning degenerat holatlarini aniqlaydi
>>>>>>> 649a0f3e6c4450403d0b2fd0b71fd99e9a969500
