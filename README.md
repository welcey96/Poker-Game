# Texas Hold'em Poker

**\*\* 2 PLAYER MODE\*\***

- **YOU** – The human player
- **BOT** – The opponent

Each player will be assigned the following roles:
- **SMALL BLIND** – will be assigned to a player with a forced bet of **$1.**
- **BIG BLIND** – will be assigned to a player with a forced bet of **$2.**

The forced bet will be added to the pot if a player folds during the **PRE-FLOP** round. If a player folds **AFTER** the pre-flop, no forced bet will be added to the pot.

**MINIMUM BET**
- The amount each player can match or raise to proceed to the next betting round.
- During **PRE-FLOP**, the minimum bet amount is set to **$2**, the Big Blind’s forced bet amount.
- It will be updated if a player does a **RAISE**.

**POT** - holds the total amount that will be won and will be updated as each round of betting happens.** 

**\*\*BETTING ROUND\*\***
- Each player has one turn per round. The first action per round will always be the “**BOT”**. 
- **“YOU”** always ends the current round.

**\*\*STAGES\*\***
- **PRE-FLOP** - 2 cards are drawn per player.
- **FLOP** - 3 community cards are drawn.
- **TURN** - 1 community card drawn.
- **RIVER** - 1 community card drawn.

When no one folds on all rounds, there will be a **SHOWDOWN** stage where the highest five-card combination from the seven cards will be selected for each player. The best five cards will be shown, and the highest-ranked hand will be determined.

**\*\*HAND RANKINGS\*\***

![HAND RANKINGS](ss.png)

**\*\*CONDITIONS\*\***
- If both players have the same hand rank, e.g., **ROYAL FLUSH**, the game will be considered a **SPLIT POT**, with each player receiving half the pot. If both players have the same rank e.g. **PAIR**, the higher kicker (card in the hand besides the pair) wins.
    1. **YOU**: J-J-Q-3-2   => **WINNER** because Q beats 7.
    1. **BOT**: J-J-7-6-4.
- If both players have a **STRAIGHT FLUSH** or **STRAIGHT**
   1. **YOU**: 2-3-4-5-A – lowest ranked straight flush or straight
   1. **BOT**: 2-3-4-5-6 => **WINNER** 

**\*\*PLAYER ACTIONS\*\***

**FOLD** – Ends the game with the other player winning the pot. 

- If **FOLD** happens during the **PRE-FLOP** and the player is either **BIG** or **SMALL** blind, they will need to surrender their force bet to the pot, so the winning player will win the pot amount plus the surrendered force bet.
- If **FOLD** happens **AFTER** the pre-flop, the winning player only wins the amount in the pot.

**CHECK** – will not bet and either moves to the next player or ends the current round. 

- **CHECK** is **NOT ALLOWED** for both players during PRE-FLOP
- **YOU** are allowed to **CHECK** if the previous player (**BOT**) decides to **CHECK**, else **NOT ALLOWED**

**RAISE** – Raises the minimum bet amount to twice the minimum bet amount.

- e.g. if the minimum bet amount is two and you decide to **RAISE**, 4 dollars will be deducted from your available chips, four will be added to the pot, and the MINIMUM BET will be updated to 4.

**CALL** – Matches the minimum bet amount; the amount will be added to the pot with no updates to the minimum bet amount.

**\*\*FLOW OF THE GAME\*\***

1. Two players will be assigned named “**YOU”** for the human player and “**BOT”** for the opponent.
1. **“YOU”** is assigned the big blind with a forced bet of 2 dollars, and “**BOT”** is the small blind with a 1 dollar forced bet.
1. 2 cards will be dealt to each player.
1. **PRE-FLOP** round begins.

	**BOT** will choose an action during **PRE-FLOP** (**CALL**).

     **YOU** will choose an action.\
     **YOU** actions during **PRE-FLOP** (**CALL, RAISE, FOLD**)

      - If **YOU** choose **FOLD**

      	- Deducts forced bet amount from the player’s available chips. 
      	- Adds force bet to Pot (big blind’s forced bet is **$2**, small blind’s forced bet is **$1**)
		- Pot will be added to **WINNER**’s available chips.
		- Game ends.

      - If **YOU** choose **CALL**
      	- Deducts minimum bet from from the player’s available chips. 
      	- Add deducted bet to Pot.
      	- Move to the next player.
      	- Move to the next round.

      - If **YOU** choose **RAISE**
      	- Minimum bet will be updated (Minimum bet = Minimum bet \* 2) 
      	- Deducts minimum bet from the player’s available chips. 
      	- Add minimum bet to Pot.
      	- Move to the next player.
      	- Move to the next round.

1. **FLOP** round begins.\
**Three** community cards will be dealt. The current highest card combination will be determined for each player. (Only **YOU**’s cards and the highest combination will be shown) 

   	 **BOT** will choose an action. (CALL, **RAISE**,**CHECK**)


	 **YOU** will choose an action. (CALL, RAISE, FOLD, **CHECK**)
     - If **YOU** choose **FOLD**
      	- The pot amount will be added to WINNER’s available chips.
      	- Game ends.

     - If **YOU** choose **CALL**

      	- Deducts minimum bet from the player’s available chips. 
      	- Add deducted bet to Pot.
      	- Move to the next player.
      	- Move to the next round.

      - If **YOU** choose **RAISE**

      	- Minimum bet will be updated (Minimum bet = Minimum bet \* 2) 
      	- Deducts minimum bet from the player’s available chips. 
      	- Add deducted bet to Pot.
      	- Move to the next player.
      	- Move to the next round.

     - If **YOU** choose **CHECK (YOU** can **CHECK** if **BOT** checked during the round**)** 
      	- Move to the next player. 
      	- Move to the next round.

1. **TURN** round begins.
**One** community card will be dealt. The current highest card combination will be determined for each player. (Only YOU’s cards and the highest combination will be shown)

	**BOT** will choose an action. (CALL, RAISE, CHECK)

	> Same actions and processes per action during FLOP

	**YOU** will choose an action. (CALL, RAISE, FOLD, CHECK)

	> Same actions and processes per action during FLOP

1.  **RIVER** round begins.
**One** community card will be dealt.The current highest card combination will be determined for each player. (Only YOU’s cards and the highest combination will be shown)

	**BOT** will choose an action. (CALL, CHECK)

	> Same actions and processes per action during FLOP

	**YOU** will choose an action. (CALL, RAISE, FOLD, CHECK)

	> Same actions and processes per action during FLOP

1.	**SHOWDOWN**
Stage when both players haven’t folded. Each player’s two cards and the five community cards will be shown.

	- **1 WINNER** - The player with the highest five-card combination among the seven cards will be 				the winner.
      	- The pot amount will be added to the **WINNER**’s available chips.
      	- Game ends.

	- **SPLIT POT** - Both players have the same five cards.
      	- The pot amount will be divided and added to both players’ available chips.
      	- Game ends.