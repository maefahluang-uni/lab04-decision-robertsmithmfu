[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=19916924)
# Computer Programming - Decision Making
***อย่าลืมลง C# Dev Kitก่อนเริ่ม*** ทำแบบฝึกหัดนี้โดยแก้ไข run() ใน Program.cs (อยู่ในโฟลเดอร์ lab)

ให้พัฒนาโปรแกรมจำลองการถอนเงินจากตู้ ATM ที่มีธนบัตร 100 บาทเท่านั้น โดยคำนึงถึงเงื่อนไขดังต่อไปนี้:

- ผู้ใช้ต้องป้อนจำนวนเงินที่ต้องการถอน
- ตรวจสอบว่าจำนวนเงินที่ป้อนเป็นจำนวนบวก
- ตรวจสอบว่าจำนวนเงินที่ป้อนไม่เกินขีดจำกัดการถอนสูงสุด (กำหนดเป็น 25,000 บาท)
- ตรวจสอบว่าจำนวนเงินที่ป้อนเป็นทวีคูณของ 100 (กรณี ATM จ่ายเป็นธนบัตร 100 บาท)

## เขียนคำสั่ง if-else แสดงผลลัพธ์ดังนี้:
- กรณีถอนเงินสำเร็จ: แสดงข้อความ
```
You have withdrawn {จำนวนเงิน} Baht.
Please take your money: {จำนวนธนบัตร 100 บาท} of 100 Baht Banknotes.
```

- กรณีจำนวนเงินที่ป้อนไม่เป็นทวีคูณของ 100: แสดงข้อความ ```There are only 100 banknotes```
- กรณีจำนวนเงินที่ป้อนเกินขีดจำกัด: แสดงข้อความ ```Exceed max withdrawal limit```
- กรณีจำนวนเงินที่ป้อนไม่เป็นจำนวนบวก: แสดงข้อความ ```Money must be more than 0```


## Running
โปรแกรมนี้สามารถรันผ่านปุ่ม run ด้านขวาบน หรือ จาก Terminal ด้วยคำสั่ง

```
dotnet run --project lab/exercise-program.csproj
```

## Testing
ทดสอบโปรแกมก่อนส่งงาน โดยรันคำสั่งด้านล่าง ผ่าน Terminal
```
dotnet test test/test-program.csproj
```
ถ้าโปรแกรมรันได้ถูกต้องจะขึ้นสีเขียว พร้อมแสดง Passed!
ถ้าโปรแกรมรันได้ผิดจะขึ้นสีแดง พร้อมแสดง Failed! ให้ตรวจสอบข้อผิดพลาดในโปรแกรมจากข้อความ error ที่ได้พบ

**หลังจากทำแบบฝึกหัดเสร็จอย่าลืม Commit & Push**
































