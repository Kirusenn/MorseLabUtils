import numpy as np

target, w2, rho

def get_diff(w1, v1):
	return w1 * (ro-1) * (v1+0.5) - (w2 * (ro-1) * 0.5)


def findw1(target, w2, vrange, rho, w1range):
	this.target = target
	this.w2 = w2
	this.rho = rho

	vrange = vrange.split(',')
	w1range = w1range.split(',')

	result = ""

	for v in range(int(vrange[0]), int(vrange[1])):
		current_diff = float("inf")
		w1

		for w in np.arange(double(w1range[0]), double(w1range[1]), 0.005):
			new_diff = abs(target - get_diff(w, v))
		
			if (new_diff < current_diff):
				w1 = w
				this.current_diff = new_diff

		result += f"v={v}:\t\u03C9={w1}\n"

	return result