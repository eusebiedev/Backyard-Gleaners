using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackyardGleanersApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gardeners",
                columns: new[] { "GardenerId", "Availability", "Contact", "Description", "Food", "Location", "Name", "ProfilePic" },
                values: new object[,]
                {
                    { 1, "August->September, Weekends, from 10am-4pm", "siebubal@gmail.com", "We've been growing a variety of tomatoes in our backyard garden for 5 yrs. They are organic, we don't use sprays or other chemical based fertilizers. There is always a surplus! We provide a pre-picked basket of tomatoes on a first come first serve basis as they go quick! This season we will be offering Sweet Millions and Sun Golds.", "Tomatoes", "N Washburne Ave & N Lombard St., Portland, OR 97217", "Eusebie and Kate", "/img/tomatoes.jpeg" },
                    { 2, "July->August, Weekends, 10am-4pm", "Cb@gmail.com", "We've been growing our prized cherry trees for many years now! These cherries are organic. When you arrive there are ladders (if needed) and over-the-shoulder baskets for you to pick and fill. Of course, feel free to bring your own cherry picking bag as well. We try to limit each gleaner to 1 full bag. Be sure to bring water and a hat!", "Cherries", "N Macrum Ave & N Lombard St, Portland, OR 97203", "Cherry Bark", "/img/cherry.jpeg" },
                    { 3, "September, Fri-Sun, 9am-3pm", "prp@gmail.com", "Our juicy plums are the best this side of the Willamette! We've had our trees for 10yrs now and they produce some of the best you can find. We grow natural and organic fruit. This is a you pick set up. Although we are glad to assist if needed. Please bring your own plum harvesting basket. We grow the Seneca variety as these are big, juicy & sweet.", "Plums", "NW 19th Ave & NW Johnson St, Portland, OR 97209", "Priscilla Plum", "/img/plums.jpeg" },
                    { 4, "July->November, Mon-Fri, 9-3pm ", "zuch@gmail.com", "We grow so many zucchinis! They are unstoppable! Classic, organic, delicious. Want to make zucchini bread, but don't have zucchinis, stop on by! This is a you pick garden. Please bring your own basket to fill. 1 basket limit per person. Exceptions will be made if you plan on sharing that amazing recipe!", "Zucchinis", "SE 9th Ave & SE Division StPortland, OR 97214", "Zack and Inna Thompson", "/img/zucchini.jpeg" },
                    { 5, "Aug->Oct, Weekends, 7am-Noon", "gs@gmail.com", "Our grandmother has been growing the best granny smith apples since she can remember. You will not be disappointed when you taste these. Her name says it all! This is a you pick situation. Ladders are provided. Don't forget to bring a hat and water! Try to limit yourself to 1 basket.. if you can!", "Apples", "NE 33rd Ave & NE Killingsworth StPortland, OR 97211", "Granny Smith", "/img/apples.jpeg" },
                    { 6, "June->August, Mon-Fri, 2-6pm", "bbsweet@gmail.com", "Backyard gardener since 2011! My main crop is organic strawberries and there is always a surplus. I can provide a pre-picked basket for pickup. The last 2 years I won biggest, tastiest strawberry at the Oregon Grower's Fair! I've been partnering with our local Portland Zoo to make use of their finest elephant manure, it powers my strawberry patch to its fullest!", "Strawberries", "SW Condor Ave & SW Barbur BlvdPortland, OR 97239", "Berry Sweetwater", "/img/strawberry.jpeg" },
                    { 7, "Sept->Nov, Thurs-Sun, 11am-4pm", "peri@gmail.com", "If you adore Persimmons, and I'm sure you do, our backyard is the place to be. Growing for decades now. We provide the tastiest organic persimmons you'll ever eat! Kids love them! Sweet and tangy. Please come with your own basket. Ladders provided if needed. You pick, or we can assist if needed.", "Persimmons", "NE 24th Ave & Northeast Broadway, Portland, OR 97232", "Padma Periwinkle", "/img/persimmons.jpeg" },
                    { 8, "Sept->Oct, 7 days a week, 10am-4pm", "hazel@gmail.com", "Everyone loves hazelnuts! We sure do. A healthy organic snack at anytime of the day. Our trees aren't too tall. But ladders will be provided. This is a you pick backyard garden! Bring your own basket please. Snacks provided for the little ones if you happen to bring them. ", "Hazelnuts", "Northwest Skyline Boulevard & Northwest Cornell Road, Forest Park, Portland, OR 97229", "Hazel Folgelstein", "/img/hazelnuts.jpeg" },
                    { 9, "July->Oct, Mon-Fri, 8am-2pm", "cc@gmail.com", "Carrie Cuke is the name and cucumbers are my game. We have a huge backyard and always have a surplus available. Please bring your own basket. You can pick, or we'll have some ready to take home if you're short on time. Organic, semi-sweet, crisp cucumbers! Great for salads, pickling or just plain chomping on a hot oregon day.", "Cucumbers", "North Mason Street & North Castle Avenue, Portland, OR 97227", "Carrie Cuke", "/img/cukes.jpeg" },
                    { 10, "Late July->Sept, Mon-Fri, 9am-3pm", "rom@gmail.com", "Welcome to Ronnie's Romaine garden. We grow the most tender organic romaine lettuce in NE Portland. We've been in operation since 2006 providing locals with greens they can depend on. The rows are spacious and easy to pick. But being fragile, we'll have bundles of romaine ready for pick up. Please bring your own basket and we hope you have a great day!", "Romaine Lettuce", "North Morgan Street & North Moore Avenue, Portland, OR 97217", "Ronnie Romulus", "/img/romaine.jpeg" },
                    { 11, "July-Oct, Fri-Mon, 8am-4pm", "kaleyg@gmail.com", "We all know that greens are good for us and having access to healthy food is our gardens priority. We've been growing local crisp kale for 4 yrs since relocating to SE Portland. Providing the community with nutrients is a wonderful thing. Our kale will be bundled and ready for pick up. Pleaes bring your own basket.", "Kale", "SE Duke St & SE 66th AvePortland, OR 97206", "Kaley Green", "/img/kale.jpeg" },
                    { 12, "August->October, Thurs-Sun, 7am-2pm", "bloom@gmail.com", "Welcome to the Bill's blueberru patch! Organic little treasures are our favorite to grow. This is a you pick garden so please bring your own crate or basket ready to fill!", "Blueberries", "Northeast Wygant Street & Northeast 10th Avenue, Portland, OR 97211", "Bill Bloom", "/img/blueberries.jpeg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Gardeners",
                keyColumn: "GardenerId",
                keyValue: 12);
        }
    }
}
