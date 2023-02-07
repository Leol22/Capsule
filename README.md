# Capsule
a short dumb esoteric language

Welcome to Capsule! I'm glad you're checking this language out.<br>
(I'm not natively english, so if i make mistakes that's why!)<br><br>
To make programs, create a text file with one command per line.<br><br>
Run programs from CMD by typing Capsule and then the filename of the program. <br>
(It's recommended to put Capsule.exe in a Path enviroment variable so you can type the Capsule command from anywhere, if you don't do this you will need to put Capsule.exe in the same folder as the program you want to execute!)
<h1> BASICS </h1>
Capsule is based on an 8x8 grid of integers, starting at 0. <br>
Every cell (or capsule) is referenced via a coordinate system simlair to battleship, every line is a letter (A-H) and every column is a number (1-8). <br>
Capsules can have positive or negative numbers. <br>
Every cell has four neighbours, U,D,L,R (Up, Down, Left and Right), with no exceptions (the grid wraps, so A1's L neighbour is A8)<br>
<br>
Additionally, there are two stacks you can use to store more information. All of this is INT only, but you can output strings via ASCII conversion.<br>
<br>If you can't figure something out and don't decide to ditch the language, feel free to DM me on discord at Leol22#0580
<h1> COMMAND SHEET </h1>
<br>
[R] indicates a coordinate, like A1, [D] indicates a neighbour direction, U,D,L,R (up, down, left and right), and [S] indicates a stack, 1 or 2.

 <table>
  <tr>
    <th>Command</th>
    <th>Use</th>

  </tr>
  <tr>
    <td>+[R]</td>
    <td>Increments [R] by 1</td>
  </tr>
  <tr>
    <td>-[R]</td>
    <td>Decrements [R] by 1</td>
  </tr>
  <tr>
    <td>F[R]</td>
    <td>Flips [R] (Positive to negative, negative to positive)</td>
  </tr>
    <tr>
    <td>I[R]</td>
    <td>Gets an input and puts it in [R]</td>
  </tr>
    <tr>
    <td>O[R]</td>
    <td>Outputs the value in R</td>
  </tr>
    <tr>
    <td>OM</td>
    <td>Changes output mode from Numbers to ASCII and backwards, default is Numbers</td>
  </tr>
    <tr>
    <td>[R]>[D]</td>
    <td>Copies [R] to one of its neighbours, indicated by [D]</td>
  </tr>
      <tr>
    <td>[R]=>[D]</td>
    <td>Moves [R] to one of its neighbours, indicated by [D] (leaves R as 0)</td>
  </tr>
        <tr>
    <td>[R]><[D]</td>
    <td>Swaps [R] with one of its neighbours</td>
  </tr>
        <tr>
    <td>[R]+>[D]</td>
    <td>Adds [R] to one of its neighbours, indicated by [D] (leaves R as 0)</td>
  </tr>
        <tr>
    <td>[R]==[D]</td>
    <td>Checks if [R] is equal to one of its neighbours</td>
  </tr>
          <tr>
    <td>[R]<<[D]</td>
    <td>Checks if [R] is less than one of its neighbours</td>
  </tr>
          <tr>
    <td>[R]>>[D]</td>
    <td>Checks if [R] is greater than one of its neighbours</td>
  </tr>
          <tr>
    <td>[R]==[D]</td>
    <td>Checks if [R] is equal to one of its neighbours</td>
  </tr>
            <tr>
    <td>[R]S[S]</td>
    <td>Will copy the value in [R] and add it to one of the two stacks, indicated by [S].</td>
  </tr>
              <tr>
    <td>[R]G[S]</td>
    <td>Will transfer the most recent value from the [S] stack to [R] (and remove it from the stack).</td>
  </tr>
                <tr>
    <td>[R]L[S]</td>
    <td>Will set [R] to the lenght of the [S] stack.</td>
  </tr>
          <tr>
    <td>M</td>
    <td>Will mark this part of the code for future jumps. This happens only once per mark before the code is executed. The first one is 0, then 1...</td>
  </tr>
          <tr>
    <td>00TJ</td>
    <td>Will jump to mark 00 if the last check came back true. Replace 00 with whatever mark you need, but it must be 2 digits.</td>
  </tr>
            <tr>
    <td>00FJ</td>
    <td>Will jump to mark 00 if the last check didn't come back true. Replace 00 with whatever mark you need, but it must be 2 digits.</td>
  </tr>
            <tr>
    <td>00AJ</td>
    <td>Will jump to mark 00. Replace 00 with whatever mark you need, but it must be 2 digits.</td>
  </tr>
              <tr>
    <td>ENDP</td>
    <td>Will end the program. If you reach the end of the code without having executed an ENDP, the program will start from the top.</td>
  </tr>
</table> 



