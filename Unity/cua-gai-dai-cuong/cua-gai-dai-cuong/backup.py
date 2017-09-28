from flask import Flask, render_template
app = Flask(__name__)


@app.route('/')
def index():
    return render_template("index.html")


@app.route("/hello")
def hello():
    return "Hello C4E11"


@app.route("/hello/hai")
def hellohai():
    return "Hello Hai"


@app.route("/hello/<name>")
def hello2(name):
    return "Hello " + name + " chó"


if __name__ == '__main__':
    app.run(debug=True)
