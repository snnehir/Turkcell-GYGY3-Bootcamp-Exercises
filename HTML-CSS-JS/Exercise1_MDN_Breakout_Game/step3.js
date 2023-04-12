const canvas = document.getElementById("myCanvas");
const ctx = canvas.getContext("2d");
const ballRadius = 10;


let x = canvas.width / 2;
let y = canvas.height - 30;
let dx = 2;
let dy = -2;
let ballColor = "#0095DD"

function drawBall() {
    ctx.beginPath();
    ctx.arc(x, y, ballRadius, 0, Math.PI * 2);
    ctx.fillStyle = ballColor;
    ctx.fill();
    ctx.closePath();
}

function draw() {
    // clear old drawn things
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    drawBall();

    x += dx;
    y += dy;

    // reverse ball movements when it hits the wall
    // bouncing off the top and bottom
    if (x + dx > canvas.width - ballRadius || x + dx < ballRadius) {
        ballColor = getRandomColor();
        dx = -dx;
    }
    // bouncing off the left and right
    if (y + dy > canvas.height - ballRadius || y + dy < ballRadius) {
        ballColor = getRandomColor();
        dy = -dy;
    }

}
// https://stackoverflow.com/a/1484514/13078360
function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

setInterval(draw, 10);
