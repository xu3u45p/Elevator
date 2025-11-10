# Elevator
- 這是一個以C#撰寫的電梯系統：Elevator.sln
- .exe執行檔在Release.zip當中

### 說明：
<img width="957" height="521" alt="image" src="https://github.com/user-attachments/assets/db51de05-1a1c-4b85-9a5a-ab4b87250d22" />

**樓層FLOOR**：代表使用者目前身處的樓層，default為1樓。
**電梯旁的數字**：代表目前電梯所在的樓層，default為1樓和7樓。
**等電梯**：可以透過在電梯旁的欄位輸入樓層，並按下call button，電梯會_移動至使用者所在的樓層_。
**搭電梯**：電梯會_移動至使用者輸入的樓層_，FLOOR則會更新為使用者移動到的樓層。
