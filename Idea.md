# LSTM prediction
A simple keras LSTM would do the work.

# Policy 1
Based on supporting interval, (low + up) / 2 of the superior supporrting interval would be the take profit price. 
And the low of the inferioir supporting interval would be the stop loss price.

By traditional algorithm, we may simply evaluate the supporting intervals.

# Policy 2
Take profit = (LSTM.high + LSTM.low) / 2

Stop loss = The price of after `K` days of unsold.

# Policy 3
Deep deterministic policy gradient, actor critic, Q-Learning, et cetera.
