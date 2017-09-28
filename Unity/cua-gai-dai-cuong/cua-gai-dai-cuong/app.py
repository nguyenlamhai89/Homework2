from flask import Flask, render_template, redirect
app = Flask(__name__)


@app.route('/')
def index():
    return render_template('backup.html', type="Câu 2")

@app.route("/school")
def school():
    return redirect("http://techkids.vn/", code=302)


@app.route("/margin")
def margin():
    return render_template("index.html", type="Câu 4")
if __name__ == '__main__':
  app.run(debug=True)
