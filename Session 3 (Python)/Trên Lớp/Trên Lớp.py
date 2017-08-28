##import webbrowser
##webbrowser.open("http://colorme.vn/posts/7")
import time
import webbrowser

while True:
    for i in range(1, 20):
        time.sleep(1)
        print("Con",20 - i,"s: ", time.ctime())
    webbrowser.open("https://www.youtube.com", time.ctime())
       

