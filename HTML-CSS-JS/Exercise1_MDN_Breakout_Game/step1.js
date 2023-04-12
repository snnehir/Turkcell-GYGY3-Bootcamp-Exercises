const canvas = document.getElementById("myCanvas");
// 2D rendering context. (used for painting on the Canvas)
const ctx = canvas.getContext("2d");

ctx.beginPath();
// rect(x, y, width, height)
ctx.rect(20, 40, 50, 50); 
ctx.fillStyle = "#FF0000";
ctx.fill();
ctx.closePath();

ctx.beginPath();
// arc(x, y, radius, start angle, end angle, false=clockwise)
ctx.arc(240, 160, 20, 0, Math.PI * 2, false); 
ctx.fillStyle = "green";
ctx.fill();
ctx.closePath();

ctx.beginPath();
ctx.rect(160, 10, 100, 40);
ctx.strokeStyle = "rgba(0, 0, 255, 0.5)";
ctx.stroke();
ctx.closePath();
