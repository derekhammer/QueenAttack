## By Derek Hammer and James Hanley
*_A Project set up, where a user inserts a Queen's co-ordinates and the co-ordinates of a piece. It then checks to see if the Queen is able to take the piece._*

## Specs
|Behavior|Input|Output|
|--------|-----|------|
|User can input co-ordinates for Queen|x1-y1|true|
|User can input co-ordinates for piece|x1-y1|true|
|User cannot place piece outside of range|x9-y1|false|
|User cannot stack pieces|x1-y1 & x1-y1|false|
|Queen can attack horizontally |x3-y1 & x3-y5|true|
|Queen can attack vertically|x3-y8 & x8-y8|true|
|Queen can attack diagonally|x1-y1 & x8-y8|true|
